USE [p2524504]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sproc_tblSupplier_Select]
		@SupplierID = 2

SELECT	@return_value as 'Return Value'

GO
