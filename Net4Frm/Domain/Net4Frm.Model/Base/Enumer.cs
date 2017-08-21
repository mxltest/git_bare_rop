using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Net4Frm.Model
{
    public static class AppEnum
    {
        #region 采购系统采购单状态
        /// <summary>
        /// 采购单状态
        /// </summary>
        public enum PurchaseStatus
        {
            [Description("新建")]
            New = 1,
            [Description("审核完成")]
            Auditing = 3,
            [Description("收货完成")]
            Receipt = 6

        }
        #endregion
        #region 报损单

        #region 报损单类型

        public enum DamageBillType
        {
            [Description("报损(正常-报损)")]
            NormalToDamage = 1,
            [Description("虚拟报损(正常-报损)")]
            VirtualNormalToDamage = 2,
            [Description("报损(报损-正常)")]
            DamageToNormal = 3,
            [Description("虚拟报损(报损-正常)")]
            VirtualDamageToNormal = 4,

            //[Description("报损")]
            //Damage = 1,
            //[Description("虚拟报损")]
            //VirtualDamage = 2,
        }

        #endregion

        #region 报损单状态

        public enum DamageBillStatus
        {
            [Description("作废")]
            Cancel = -1,
            [Description("初始")]
            Init = 0,
            //[Description("已确认")]
            //Confirmed = 1,
            //[Description("已驳回")]
            //Reject = 2,
            [Description("已审核")]
            Audited = 4,
            [Description("已刷单")]
            Sorted = 8,
            [Description("已出库")]
            Outbound = 16,
            //[Description("完成")]
            //Completed = 32
        }
        #endregion

        #endregion

        #region 报废单
        #region 报废单类型

        public enum ScrapBillType
        {
            [Description("实体报废")]
            Scrap = 1,
            [Description("虚拟报废")]
            VirtualScrap = 2,
        }

        #endregion

        #region 报废单状态

        public enum ScrapBillStatus
        {
            [Description("作废")]
            Cancel = -1,
            [Description("初始")]
            Init = 0,
            [Description("已确认")]
            Confirmed = 1,
            [Description("已驳回")]
            Reject = 2,
            [Description("已审核")]
            Audited = 4,
            [Description("已刷单")]
            Sorted = 8,
            [Description("已出库")]
            Outbound = 16,
            [Description("完成")]
            Completed = 32
        }
        #endregion
        #endregion

        #region RF操作类型

        public enum RFOperatoryType
        {
            [Description("商品信息维护")]
            ProductInfoOam = 1,
            [Description("移库")]
            MoveInv = 2
        }

        #endregion

        #region PMS退供应商商品类型
        public enum ReturnWarehouseType
        {
            [Description("网站")]
            Website = 1,
            [Description("海淘")]
            UnKnow = 2
        }

        #endregion

        #region 礼品卡状态
        public enum GiftCardStatus
        {
            [Description("不可用")]
            NotAvailable = -1,
            [Description("未使用")]
            NotUsed = 0,
            //[Description("占用中")]
            //Occupancy = 1,
            [Description("已使用")]
            HasBeenUsed = 2,
        }
        #endregion

        #region 门店相关枚举
        #region 门店日结项目类型
        public enum DailyItemType
        {
            [Description("现金收入")]
            CashIncome = 1,
            [Description("银行卡收入")]
            CardIncome = 2,
            [Description("退货收入")]
            ReturnIncome = 3,
            [Description("退货支出")]
            ReturnExpenditure = 4,
        }
        #endregion
        #region 门店退货
        #region 申请退货原因
        /// <summary>
        /// 申请退货的原因
        /// </summary>
        public enum ApplyReasonType
        {
            [Description("质量问题")]
            Quality = 1,
            [Description("非质量问题")]
            NotQuality = 2,
        }
        #endregion

        #region 退换货类型（服务类型）
        /// <summary>
        /// 退换货类型（服务类型）
        /// </summary>
        public enum ServiceType
        {
            [Description("退货")]
            Return = 1,
            [Description("换货")]
            Exchange = 2,
            //[Description("维修")]
            //Fix = 3,
        }
        #endregion

        #region 退货类型
        /// <summary>
        /// 退货类型
        /// </summary>
        public enum ReturnType
        {
            /*[Description("售前退货")]
            PreSale = 1,
            [Description("售后退货")]
            AfterSale = 2,*/
            [Description("全部拒收")]
            DangChangJuShou = 1,
            [Description("半收半退")]
            BanShouBanTui = 2,
            [Description("售后退货")]
            ShouHouTuiHuo = 4
        }
        #endregion

        #region 退换货单状态
        /// <summary>
        /// 退换货单状态
        /// </summary>
        public enum ReturnedGoodStatus
        {
            [Description("新建待审核")]
            Init = 0,
            [Description("已审核待取件")]
            WaitingTake = 1,
            [Description("已审核待寄回")]
            WaitingReturn = 2,
            [Description("已审核待回库")]
            WaitingBack = 4,
            [Description("取件中")]
            Taking = 8,
            [Description("寄回中")]
            Returning = 16,
            [Description("回库中")]
            Backing = 32,
            [Description("退货已入库")]
            Backed = 64,
            [Description("退货完成")]
            Complete = 128,
            [Description("作废")]
            Invalid = -1,
        }
        #endregion
        #endregion

        #region 门店状态
        public enum BranchStatus
        {
            [Description("正常")]
            Open = 0,
            [Description("关店")]
            Close = 1,
        }
        #endregion

        #region 订单来源
        /// <summary>
        /// 订单来源
        /// </summary>
        public enum OrderSourceType
        {
            [Description("电销")]
            E_Sale = 100,
            [Description("门店")]
            Store = 101,
            [Description("网站")]
            WebSite = 102
            //[Description("站点")]
            //WebSite = 1,
            //[Description("手机Wap")]
            //Wap = 2,
            //[Description("Andriod")]
            //AndroidApp = 4,
            //[Description("IOS")]
            //IosApp = 5,
            //[Description("电销-呼出")]
            //ESale_Out = 6,
            //[Description("电销-呼入")]
            //ESale_In = 7,
            //[Description("淘宝")]
            //Taobao = 16,
        }
        #endregion

        #region 门店库存变化
        /// <summary>
        /// 类型
        /// </summary>
        public enum BranchInventoryChangeType
        {
            [Description("订单")]
            Order = 1,
            [Description("退货")]
            Return = 2,
            [Description("门店补货")]
            W_To_B = 3,
            [Description("门店退仓")]
            B_To_W = 4,
        }
        /// <summary>
        /// 状态
        /// </summary>
        public enum BranchInventoryChangeStatus
        {
            [Description("初始")]
            Initial = 1,
        }

        #endregion
        #endregion

        #region 单据出库记录类型

        public enum BillOutboundRecordType
        {
            [Description("调拨")]
            TransferMaster = 1,
            [Description("退供应商")]
            ReturnVendor = 2,
            [Description("报废")]
            Scrap = 3,
        }

        #endregion

        #region 退供应商类型
        public enum ReturnVendorType
        {
            /// <summary>
            /// 未知
            /// </summary>
            None = 0,
            [Description("采购退供应商")]
            PurchaseReturnVendor = 1
        }
        #endregion

        #region 退供应商状态
        public enum ReturnVendorStatus
        {
            [Description("作废")]
            Cancal = -1,
            [Description("初始")]
            Init = 0,
            [Description("已审核")]
            Audited = 1,
            [Description("已刷单")]
            Sorted = 2,
            [Description("已出库")]
            Complete = 4,
        }
        #endregion

        #region 调拨单申请单状态
        public enum TransferOrderStatus
        {
            [Description("作废")]
            Cancal = -1,
            [Description("新建")]
            Init = 0,
            [Description("已审核")]
            Audited = 1,
            [Description("已复核")]
            Review = 2,
            [Description("待生产")]
            UnCreate = 4,
            [Description("已出库")]
            Out = 8,
            [Description("收货中")]
            ReceiptOf = 16,
            [Description("完成")]
            Complete = 32,
        }
        #endregion

        #region 调拨单状态
        public enum TransferMasterStatus
        {
            [Description("作废")]
            Cancal = -1,
            [Description("初始")]
            Init = 0,
            [Description("已审核")]
            Audited = 1,
            [Description("已刷单")]
            Sorted = 2,
            [Description("已出库")]
            Outbound = 4,
        }
        #endregion

        #region 调拨单类型

        public enum TransferOrderType
        {
            [Description("仓调")]
            W_To_W = 1,
            [Description("仓店")]
            W_To_B = 2,
            [Description("店仓")]
            B_To_W = 3,
        }
        #endregion

        #region 路径类型
        public enum PathType
        {
            [Description("上架路径")]
            Shelves = 1,
            [Description("拣货路径")]
            Picking = 2
        }
        #endregion

        #region 路径是否启用

        public enum PathDelete
        {
            [Description("启用")]
            Enable = 1,
            [Description("禁用")]
            Disable = 0
        }

        public enum PathDeleteVal
        {
            [Description("启用")]
            Enable = 0,
            [Description("禁用")]
            Disable = 1
        }
        #endregion

        #region 库位类型
        public enum LocationType
        {
            [Description("拣货位")]
            Picking = 1,
            [Description("存储位")]
            Storage = 2,
            [Description("拣货暂存位")]
            PickingTemporary = 4,
            [Description("库位")]
            Location = 7,
            [Description("包装位")]
            Packing = 8,
            [Description("托盘")]
            Pallet = 16
        }
        #endregion

        #region 数据来源
        public enum DataSourceType
        {
            /// <summary>
            /// 未知
            /// </summary>
            OMS = 1,

            /// <summary>
            /// 初始
            /// </summary>
            DMS = 2,

            /// <summary>
            /// 初始
            /// </summary>
            CS = 3
        }
        #endregion

        #region 收货类型
        public enum ReceiptType
        {
            /// <summary>
            /// 未知
            /// </summary>
            None = 0,
            [Description("采购入库")]
            POInbound = 1,
            [Description("商品正常退货入库")]
            NormalReturn = 2,
            [Description("商品部质量退货入库")]
            PMSReturn = 4,
            [Description("客服报损退货入库")]
            CSReturn = 8,
            [Description("仓库报损退货入库")]
            WMSReturn = 16,

            #region old
            ////[Description("退货入库(包含所有的退货)")]
            ////Return=30,
            ////[Description("订单取消入库")]
            ////OrderCancel=32,
            ////[Description("财务内部调拨入库")]
            ////TransferInbound = 64,
            ////[Description("损益入库")]
            ////Salesadjustment = 128,
            ////[Description("商品转换入库")]
            ////SKUTransfer = 256
            #endregion

            [Description("海淘退货入库")]
            SeaAmoyApply = 32,
            [Description("退货入库(包含所有的退货)")]
            Return = 62,
            [Description("订单取消入库")]
            OrderCancel = 64,
            [Description("财务内部调拨入库")]
            TransferInbound = 128,
            [Description("损益入库")]
            Salesadjustment = 256,
            [Description("商品转换入库")]
            SKUTransfer = 512
        }
        #endregion

        #region 收货状态
        public enum ReceiptStatus
        {
            /// <summary>
            /// 未知
            /// </summary>
            None = 0,

            /// <summary>
            /// 初始
            /// </summary>
            Initial = 1,

            /// <summary>
            /// 收货中
            /// </summary>
            Receipting = 2,

            /// <summary>
            /// 已完成
            /// </summary>
            Fished = 3,

            /// <summary>
            /// 已关闭
            /// </summary>
            Closed = 4,

            /// <summary>
            /// 关单中
            /// </summary>
            Closing = 6,

            /// <summary>
            ///  已作废
            /// </summary>
            Canceled = 8
        }
        #endregion

        #region 收货记录队列状态
        public enum ReceiptRecordQueueStatus
        {
            [Description("未知")]
            None = 0,
            [Description("初始")]
            Initial = 1,
            [Description("生产上架任务中")]//
            TaskCreating = 2,
            [Description("已产上架任务")]//
            TaskCreated = 4,
            [Description("已取消")]
            Canceled = 8
        }
        #endregion

        #region 收货记录状态
        public enum ReceiptRecordStatus
        {
            [Description("未知")]
            None = 0,
            [Description("初始")]
            Initial = 1,
            [Description("已完成(已关单)")]
            Fished = 2,
            [Description("已取消")]
            Canceled = 4
        }
        #endregion

        #region 收货单产上架单状态
        public enum ReceiptPutawayStatus
        {
            [Description("未产生")]
            UnCreate = 1,
            [Description("生产中")]
            Creating = 2,
            [Description("已产生")]
            Created = 4
        }
        #endregion

        #region 上架状态
        public enum PutawayStatus
        {
            [Description("未知")]
            None = 0,
            [Description("初始")]
            Initial = 1,
            [Description("上架中")]
            Putting = 2,
            [Description("已完成")]
            Finished = 3,
            [Description("已关闭")]
            Closed = 4,
            [Description("已取消")]
            Canceled = 8
        }
        #endregion

        #region 上架行状态
        public enum PutawayDetailStatus
        {
            /// <summary>
            /// 未知
            /// </summary>
            None = 0,

            /// <summary>
            /// 初始
            /// </summary>
            Initial = 1,

            /// <summary>
            /// 已完成
            /// </summary>
            Fished = 2
        }
        #endregion

        #region 上架类型
        public enum PutawayType
        {
            [Description("未知")]
            None = 0,
            [Description("采购上架")]
            RecPut = 1,
            [Description("补货上架")]
            RepPut = 2,
            [Description("订单取消")]
            OcPut = 4,
            [Description("正常退货")]
            NormalReturnPut = 8,
            [Description("商品报损")]
            PmsReturnPut = 16,
            [Description("客服报损")]
            CsReturnPut = 32,
            [Description("仓库报损")]
            WmsReturnPut = 64,
            [Description("退货上架")]
            ReturnPut = 128
        }
        #endregion

        #region 任务类型
        public enum TranType
        {
            /// <summary>
            /// 未知
            /// </summary>
            None = 0,

            /// <summary>
            /// 收货
            /// </summary>
            Receipt = 1,

            /// <summary>
            /// 上架
            /// </summary>
            Putaway = 2,

            /// <summary>
            /// 补货
            /// </summary>
            Replenish = 3,

            /// <summary>
            /// 移库
            /// </summary>
            Move = 4,

            /// <summary>
            /// 拣选
            /// </summary>
            Pick = 5,

            /// <summary>
            /// 打包
            /// </summary>
            Pack = 6,

            /// <summary>
            /// 发运
            /// </summary>
            Shipment = 7,

            /// <summary>
            /// 调整（盘点调整）
            /// </summary>
            Adjust = 8,

            /// <summary>
            /// 扣减库存（老ERP）
            /// </summary>
            OldErpReduce = 9,

            /// <summary>
            /// 加库存（老ERP）
            /// </summary>
            OldErpAdd = 10,

            /// <summary>
            /// 移库（老ERP）
            /// </summary>
            OldErpMove = 11,

            /// <summary>
            /// 仓库调拨
            /// </summary>
            TransferWarehouse = 12,

            /// <summary>
            /// 退供应商
            /// </summary>
            ReturnVendor = 13,

            /// <summary>
            /// 报废
            /// </summary>
            Scrap = 14,

        }
        #endregion

        #region 任务状态
        public enum InvChanPlanStatus
        {
            /// <summary>
            /// 未知
            /// </summary>
            None = 0,

            /// <summary>
            /// 初始
            /// </summary>
            Initial = 1,

            /// <summary>
            /// 待执行
            /// </summary>
            StayExec = 2,

            /// <summary>
            /// 执行中
            /// </summary>
            Executing = 4,

            /// <summary>
            /// 未完成
            /// </summary>
            Unfinished = Initial | StayExec | Executing,

            /// <summary>
            /// 已执行
            /// </summary>
            Finished = 8,

            /// <summary>
            /// 已取消
            /// </summary>
            Canceled = 16
        }
        #endregion

        #region 订单类型
        public enum OrderType
        {
            #region old
            //[Description("销售订单")]
            //SaleOrder = 1,

            //[Description("医务订单")]
            //YiWu = 5,
            //[Description("代理商订单")]
            //DaiLiShang = 6,
            //[Description("客服批发订单")]
            //KeFuPiFa = 11,
            //[Description("特殊")]
            //TeShu = 12,
            //[Description("淘宝订单")]
            //TaoBao = 14,
            //[Description("特卖订单")]
            //TeMai = 15,
            //[Description("网盟订单")]
            //WangMeng = 16,
            //[Description("团购订单")]
            //TuanGou = 17,
            //[Description("宝优网订单")]
            //BaoYouWang = 18,
            //[Description("淘宝C店订单")]
            //TaoBao_C = 19,
            //[Description("直销订单")]
            //ZhiXiao = 20,
            //[Description("合生元兑换订单")]
            //HeShengYuan = 21,
            //[Description("闪购预售")]
            //ShanGouYuShou = 22,
            //[Description("闪购入仓")]
            //ShanGouRuCang = 23,
            //[Description("闪购供应商发货")]
            //ShanGouGongYingShang = 24,
            //[Description("闪购预售（直销）")]
            //SGYS_ZhiXiao = 25,
            //[Description("闪购入仓（直销）")]
            //SGRC_ZhiXiao = 26,
            //[Description("闪购供应商发货（直销）")]
            //SGGYS_ZhiXiao = 27,
            //[Description("WebApp")]
            //WebApp = 28,
            //[Description("Android订单")]
            //AndroidApp = 29,
            //[Description("IOS订单")]
            //IOSApp = 30,
            //[Description("平安银行订单")]
            //PingAn_Bank = 31,
            //[Description("丽婴房O2O订单")]
            //LiYingFang_O2O = 32,
            //[Description("WebApp订单-海淘")]
            //WebApp_HaiTao = 33,
            //[Description("Android订单-海淘")]
            //Android_HaiTao = 34,
            //[Description("IOS订单-海淘")]
            //IOS_HaiTao = 35,
            //[Description("VIP订单")]
            //Vip = 36,
            //[Description("新特卖")]
            //NewFlashBuy = 2,
            //[Description("海淘直邮")]
            //UnKnow1 = 4,
            //[Description("海淘自贸")]
            //UnKnow2 = 8,
            ///* [Description("未知类型3")]
            // UnKnow3 = 16*/
            #endregion

            [Description("销售订单")]
            SaleOrder = 1,

            [Description("医务订单")]
            YiWu = 5,
            [Description("代理商订单")]
            DaiLiShang = 6,
            [Description("客服批发订单")]
            KeFuPiFa = 11,
            [Description("特殊")]
            TeShu = 12,
            [Description("淘宝订单")]
            TaoBao = 14,
            [Description("特卖订单")]
            TeMai = 15,
            [Description("网盟订单")]
            WangMeng = 16,
            [Description("团购订单")]
            TuanGou = 17,
            [Description("宝优网订单")]
            BaoYouWang = 18,
            [Description("淘宝C店订单")]
            TaoBao_C = 19,
            [Description("直销订单")]
            ZhiXiao = 20,
            [Description("合生元兑换订单")]
            HeShengYuan = 21,
            [Description("闪购预售")]
            ShanGouYuShou = 22,
            [Description("闪购入仓")]
            ShanGouRuCang = 23,
            [Description("闪购供应商发货")]
            ShanGouGongYingShang = 24,
            [Description("闪购预售（直销）")]
            SGYS_ZhiXiao = 25,
            [Description("闪购入仓（直销）")]
            SGRC_ZhiXiao = 26,
            [Description("闪购供应商发货（直销）")]
            SGGYS_ZhiXiao = 27,
            [Description("WebApp")]
            WebApp = 28,
            [Description("Android订单")]
            AndroidApp = 29,
            [Description("IOS订单")]
            IOSApp = 30,
            [Description("平安银行订单")]
            PingAn_Bank = 31,
            [Description("丽婴房O2O订单")]
            LiYingFang_O2O = 32,
            [Description("WebApp订单-海淘")]
            WebApp_HaiTao = 33,
            [Description("Android订单-海淘")]
            Android_HaiTao = 34,
            [Description("IOS订单-海淘")]
            IOS_HaiTao = 35,
            [Description("VIP订单")]
            Vip = 36,

            [Description("虚拟订单")]
            Virtual = 37,
            [Description("换货订单")]
            Exchange = 38,

            [Description("新特卖")]
            NewFlashBuy = 2,
            [Description("海淘直邮")]
            UnKnow1 = 4,
            [Description("海淘自贸")]
            UnKnow2 = 8,
            [Description("礼品卡订单")]
            GiftCard = 64,

            [Description("门店订单")]
            Store = 65,
            [Description("批发订单(海淘)")]
            HTPiFa = 66,

        }
        #endregion


        #region 订单状态
        public enum OrderStatus
        {
            [Description("未分单")]
            Incomplete = 0,

            [Description("初始")]
            Initial = 1,

            [Description("加入波次")]
            InWave = 2,

            [Description("待拣货")]
            StayPick = 3,

            [Description("拣货中")]
            Picking = 4,

            [Description("待分拣（待刷单）")]
            StaySort = 6,

            [Description("待打包")]
            StayPack = 8,

            [Description("已打包")]
            Packed = 16,

            [Description("已出库")]
            Outbound = 32,

            [Description("已取消")]
            Canceled = 64,

            [Description("缺货")]
            OOS = 128
        }
        #endregion

        #region 订单明细状态
        public enum OrderDelStatus
        {
            /// <summary>
            /// 未知
            /// </summary>
            None = 0,

            /// <summary>
            /// 初始
            /// </summary>
            Initial = 1
        }
        #endregion

        #region 波次状态
        public enum WaveStatus
        {
            /// <summary>
            /// 未知
            /// </summary>
            None = 0,

            /// <summary>
            /// 初始
            /// </summary>
            Initial = 1,

            /// <summary>
            /// 已释放（以后为自动波次准备）
            /// </summary>
            Released = 2,

            /// <summary>
            /// 执行中
            /// </summary>
            Processing = 4,

            /// <summary>
            /// 执行成功
            /// </summary>
            Success = 8,

            /// <summary>
            /// 拣货中
            /// </summary>
            Picking = 16,

            /// <summary>
            /// 拣货完成
            /// </summary>
            Picked = 32,

            /// <summary>
            /// 总拣中
            /// </summary>
            Collecting = 64,

            /// <summary>
            /// 总拣完成
            /// </summary>
            Collected = 128,

            /// <summary>
            /// 作废
            /// </summary>
            Cancel = 256,
        }
        #endregion

        #region 波次订单状态
        public enum WaveOrderStatus
        {
            /// <summary>
            /// 未知
            /// </summary>
            None = 0,

            /// <summary>
            /// 初始
            /// </summary>
            Initial = 1,

            /// <summary>
            /// 已释放(以后为自动波次准备)
            /// </summary>
            Released = 2,

            /// <summary>
            /// 处理中
            /// </summary>
            Processing = 4,

            /// <summary>
            /// 已退回
            /// </summary>
            Returned = 8
        }
        #endregion

        #region 拣货单状态
        public enum PickStatus
        {
            /// <summary>
            /// 未知
            /// </summary>
            None = 0,

            /// <summary>
            /// 初始
            /// </summary>
            New = 1,

            /// <summary>
            /// 待拣货（供以后人工穿创建释放用）
            /// </summary>
            StayPick = 2,

            /// <summary>
            /// 拣货中
            /// </summary>
            Picking = 3,

            /// <summary>
            /// 已完成
            /// </summary>
            Finished = 4,

            /// <summary>
            /// 已取消
            /// </summary>
            Cancel = 8
        }
        #endregion

        #region 拣货单明细状态
        public enum PickDetailStatus
        {
            /// <summary>
            /// 未知
            /// </summary>
            None = 0,

            /// <summary>
            /// 初始
            /// </summary>
            Initial = 1,

            /// <summary>
            /// 缺货
            /// </summary>
            Shortage = 2,

            /// <summary>
            /// 已完成
            /// </summary>
            Finished = 3
        }
        #endregion

        #region 包裹状态
        public enum CartonStatus
        {
            /// <summary>
            /// 未知
            /// </summary>
            None = 0,

            /// <summary>
            /// 初始(打包好未扣库存的状态)
            /// </summary>
            Initial = 1,

            /// <summary>
            /// 已打包
            /// </summary>
            Packed = 2,

            /// <summary>
            /// 已装车
            /// </summary>
            Shipped = 4,

            /// <summary>
            /// 已出库
            /// </summary>
            Outbound = 8,

            /// <summary>
            /// 已取消
            /// </summary>
            Canceled = 16
        }
        #endregion

        #region 数据筛选器类型
        public enum DataFilterType
        {
            /// <summary>
            /// 未知
            /// </summary>
            None = 0,

            /// <summary>
            /// 订单筛选器
            /// </summary>
            OrderFilter = 1,

            /// <summary>
            /// 补货筛选器
            /// </summary>
            ReplenishFilter = 2,

            /// <summary>
            /// 盘点筛选器
            /// </summary>
            CycleCountFilter = 4
        }
        #endregion

        #region 补货状态
        public enum ReplenishStatus
        {
            /// <summary>
            /// 未知
            /// </summary>
            None = 0,

            /// <summary>
            /// 初始
            /// </summary>
            Initial = 1,

            /// <summary>
            /// 任务产生中
            /// </summary>
            Processing = 2,

            /// <summary>
            /// 待补货（以后加入自动补货产生会用这个状态，相当于释放）
            /// </summary>
            StayReplenish = 4,

            /// <summary>
            /// 补货中
            /// </summary>
            Replenishing = 8,

            /// <summary>
            /// 补货完成
            /// </summary>
            Finished = 16,

            /// <summary>
            /// 已取消
            /// </summary>
            Canceled = 32
        }
        #endregion

        #region 盘点类型
        public enum CCType
        {
            [Description("明盘")]
            Light = 1,
            [Description("暗盘")]
            Grey = 2
        }
        #endregion

        #region 盘点次序(初盘、复盘、三盘)
        public enum CycleCountJobType
        {
            /// <summary>
            /// 初盘
            /// </summary>
            First = 1,
            /// <summary>
            /// 复盘
            /// </summary>
            Second = 2,
            /// <summary>
            /// 三盘
            /// </summary>
            Third = 3
        }
        #endregion

        #region 盘点单状态
        public enum CCStatus
        {
            /// <summary>
            /// 未知
            /// </summary>
            None = 0,

            /// <summary>
            /// 新建
            /// </summary>
            Initial = 1,

            /// <summary>
            /// 待盘点（以后加入自动盘点产生会用这个状态，相当于释放）
            /// </summary>
            StayCycleCount = 4,

            /// <summary>
            /// 盘点中
            /// </summary>
            CycleCounting = 8,

            /// <summary>
            /// 盘点完成（仓库完成，创建调整单）
            /// </summary>
            Finished = 16,

            /// <summary>
            /// 已取消
            /// </summary>
            Canceled = 32,

            /// <summary>
            /// 关闭
            /// </summary>
            Closed = 64,

            /// <summary>
            /// 提交（仓库提交到财务）
            /// </summary>
            Submit=128,

            /// <summary>
            /// 确认（财务确认）
            /// </summary>
            Confirm=256
        }
        #endregion

        #region 调整单状态
        public enum AdjustMentStatus
        {
            /// <summary>
            /// 未知
            /// </summary>
            None = 0,

            /// <summary>
            /// 新建
            /// </summary>
            Initial = 1,

            /// <summary>
            /// 待審核
            /// </summary>
            StayAudit = 4,

            /// <summary>
            /// 審核中
            /// </summary>
            Auditting = 8,

            /// <summary>
            /// 審核完成
            /// </summary>
            Finished = 16,

            /// <summary>
            /// 已作废
            /// </summary>
            Canceled = 32
        }
        #endregion

        #region 调整单类型
        public enum AdjustmentType
        {
            [Description("手动调整")]
            ManualAdjust = 1,
            [Description("盘点调整")]
            CCAdjust = 2,
            [Description("商品转换调整")]
            CommodityConvertion = 4
        }
        #endregion

        #region 库位是否已绑定
        public enum LocStatus
        {
            [Description("已绑定")]
            Bound = 1,
            [Description("未绑定")]
            Unbound = 2
        }
        #endregion

        #region 是否有库存
        public enum StockQty
        {
            [Description("有库存")]
            Inventory = 1,
            [Description("零库存")]
            ZeroInventory = 2
        }
        #endregion

        #region 库区类型
        public enum ZoneType
        {
            [Description("收货区")]
            ReceiptZone = 1,
            [Description("存储区")]
            StorageZone = 2,
            [Description("拣货区")]
            PickingZone = 4,
            [Description("打包区")]
            PackingZone = 8,
            [Description("发货区")]
            ShipZone = 16,
            [Description("报损区")]
            DefectZone = 32,
            [Description("报废区")]
            DamageZone = 64

            //[Description("报损区")]
            //WMSDamageZone = 8,
            //[Description("收货暂存区")]
            //PMSDamageZone = 16,
            //[Description("发货暂存区")]
            //CSDamageZone = 32
        }
        #endregion

        #region 波次创建模式
        public enum WaveCreateModeType
        {
            [Description("手动")]
            Manual = 1,
            [Description("自动")]
            Auto = 2
        }
        #endregion

        #region 移库状态
        public enum MoveStatus
        {
            /// <summary>
            /// 未知
            /// </summary>
            None = 0,

            /// <summary>
            /// 新建
            /// </summary>
            Initial = 1,

            /// <summary>
            /// 已释放
            /// </summary>
            Released = 2,

            /// <summary>
            /// 完成
            /// </summary>
            Finished = 4,

            /// <summary>
            /// 已取消
            /// </summary>
            Canceled = 8
        }
        #endregion

        #region 移库类型

        public enum MoveType
        {
            /// <summary>
            /// 未知
            /// </summary>
            None = 0,

            /// <summary>
            /// 报损移库（正常库位到报损库位）
            /// </summary>
            DamageMove = 1,

            /// <summary>
            /// 正常移库（正常库位到正常  禁止：报损到报损）
            /// </summary>
            NormalMove = 2,

            /// <summary>
            /// 报废移库（报损库位报废  正常到报废）
            /// </summary>
            ScrapMove = 4
        }

        #endregion

        #region 移库行状态
        public enum MoveDelStatus
        {
            /// <summary>
            /// 初始
            /// </summary>
            Initial = 1,

            /// <summary>
            /// 完成
            /// </summary>
            Finished = 2,

            /// <summary>
            /// 取消
            /// </summary>
            Cancel = 3
        }
        #endregion

        #region 发票类型
        public enum InvoiceType
        {
            [Description("无发票")]
            None = 0,
            [Description("普通发票")]
            Normal = 1,
            [Description("增值税发票")]
            VAT = 2,
            [Description("有发票")]
            Have = 3,
            [Description("--All--")]
            All = 4,
        }
        #endregion

        #region 库存状态
        public enum InvStatus
        {
            [Description("未冻结")]
            UnLocked = 0,
            [Description("冻结")]
            Locked = 1
        }
        #endregion

        #region 承运商
        //承运商运单号是否落地
        public enum ExpressNoIsLandLocal
        {
            [Description("否")]//母婴之家
            No = 0,
            [Description("是")]//当前公司
            Yes = 1
        }
        #endregion

        #region ERP支付方式（除财务）
        public enum ErpPayType
        {
            [Description("货到付款（现金）")]
            Cod_Cash = 1,
            [Description("货到付款（刷卡）")]
            Cod_Pos = 2,
            [Description("在线支付")]
            Online = 4,
            [Description("混合支付")]
            Multi_Pay = 8,
            [Description("即时支付")]
            JIT_Pay = 16,
            [Description("即时支付(银行卡)")]
            Bank_Pay = 17,
        }
        #endregion

        #region ERP库存调整类型
        public enum ErpAdjustmentType
        {
            [Description("收货")]
            ErpReceipt = 1,
            [Description("新品收货")]
            ErpNewReceipt = 2,
            [Description("报损")]
            ErpApplyDamage = 4,
            [Description("报废")]
            ErpApplyScrap = 8,
            [Description("盘点")]
            ErpCycleCount = 16,
            [Description("调拨出库")]
            ErpTransfer = 32,
            [Description("商品转换")]
            ErpSkuConversion = 64,
            [Description("报损转正")]
            ErpApplyDamageToNormal = 128,
            [Description("退供应商")]
            ErpReturnVendor = 256
        }
        #endregion

    }
}
