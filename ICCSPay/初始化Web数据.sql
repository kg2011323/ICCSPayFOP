truncate table [MobilePayDB].[dbo].[WebOrder]
truncate table [MobilePayDB].[dbo].[WebOrderVoucher]
truncate table [MobilePayDB].[dbo].[WebOrderRefund]

update [MobilePayDB].[dbo].[VoucherList]
set [IsValid] = 1
      ,[IsUsed] = 0
      ,[IsLocked] = 0