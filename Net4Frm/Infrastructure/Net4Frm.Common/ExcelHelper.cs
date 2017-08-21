using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;

namespace Net4Frm.Common
{
    public class ExcelHelper
    {
        private ExcelHelper()
        { }
        private static ExcelHelper _instance;
        public static ExcelHelper GetInstance()
        {
            return _instance ?? new ExcelHelper();
        }
        private HSSFWorkbook _workbook;
        private Sheet _sheet;

        /// <summary>
        /// 通过处理excel文件字节数组转化为ModelList
        /// </summary>
        /// <typeparam name="T">泛型类（需要属性顺序与Excel字段顺序一致）</typeparam>
        /// <param name="bytes">字节数组</param>
        /// <param name="fieldArray">字段名</param>
        /// <returns></returns>
        public DataTable ReadExcelToDataTable(byte[] bytes, string[] fieldArray)
        {
            if (bytes.Count() <= 0)
            {
                return null;
            }

            Stream steam = new MemoryStream(bytes, 0, bytes.Count());

            if (steam.Length <= 0)
            {
                return null;
            }

            _workbook = new HSSFWorkbook(steam);
            _sheet = _workbook.GetSheetAt(0);

            IEnumerator rows = _sheet.GetRowEnumerator();
            rows.MoveNext();

            DataTable dataTable = new DataTable();
            //循环构造指定的DataTable
            foreach (var field in fieldArray)
            {
                dataTable.Columns.Add(field);
            }
            var fieldArrayLength = fieldArray.Count();

            while (rows.MoveNext())
            {
                var row = (HSSFRow)rows.Current;
                var cellNum = row.LastCellNum;
                //取最小的长度
                var minNum = Math.Min(fieldArrayLength, cellNum);
                string[] values = new string[minNum];
                for (int i = 0; i < minNum; i++)
                {
                    Cell cell = row.GetCell(i);
                    values[i] = cell == null ? "" : cell.ToString();
                }
                //没有值的一行自动剔除，不加入
                dataTable.Rows.Add(values);
            }

            return dataTable;
        }

        /// <summary>
        /// 导入excel组装datatable
        /// </summary>
        /// <param name="bytes">字节数组</param>
        /// <param name="fieldArray">字段数组，与数据库一致</param>
        /// <param name="rowAction">为每行定义的执行函数</param>
        /// <param name="cellFuncs">为每列定义的执行函数</param>
        /// <returns></returns>
        public DataTable ReadExcelToDataTable(byte[] bytes, string[] fieldArray, Action<object[]> rowAction, Func<string, object>[] cellFuncs)
        {
            if (bytes.Count() <= 0)
            {
                return null;
            }
            Stream steam = new MemoryStream(bytes, 0, bytes.Count());
            if (steam.Length <= 0)
            {
                return null;
            }
            _workbook = new HSSFWorkbook(steam);
            _sheet = _workbook.GetSheetAt(0);

            IEnumerator rows = _sheet.GetRowEnumerator();
            //rows.MoveNext();
            DataTable dataTable = new DataTable();
            //循环构造指定的DataTable
            foreach (var field in fieldArray)
            {
                dataTable.Columns.Add(field);
            }
            var fieldArrayLength = fieldArray.Count();
            while (rows.MoveNext())
            {
                var row = (HSSFRow)rows.Current;
                var firstCell = row.GetCell(0);
                if (firstCell == null)
                {
                    throw new Exception("导入格式错误，导入终止！");
                }
                var verifyCellValue = firstCell.ToString().Trim();
                if (verifyCellValue == "#START")
                {
                    rows.MoveNext();
                    continue;
                }
                if (verifyCellValue == "#END")
                {
                    break;
                }
                //取最小的长度
                object[] values = new object[fieldArrayLength];
                int j = 0;
                for (int i = 0; i < fieldArrayLength; i++)
                {
                    if (cellFuncs != null)
                    {
                        if (cellFuncs[i] != null)
                        {
                            Cell cell = row.GetCell(j);
                            string cellValue = cell == null ? "" : cell.ToString();
                            values[i] = cellFuncs[i](cellValue);
                            if (j < row.LastCellNum)
                            {
                                j++;
                            }
                        }
                        else
                        {
                            values[i] = string.Empty;
                        }
                    }
                    else
                    {
                        values[i] = string.Empty;
                    }
                }
                //定义每行执行的方法
                object[] cells = new object[row.LastCellNum];
                for (int i = 0; i < row.LastCellNum; i++)
                {
                    var cell = row.GetCell(i);
                    cells[i] = cell == null ? "" : cell.ToString();
                }

                if (rowAction != null)
                {
                    rowAction(cells);
                }

                //没有值的一行自动剔除，不加入
                dataTable.Rows.Add(values);
            }

            return dataTable;
        }
    }
}
