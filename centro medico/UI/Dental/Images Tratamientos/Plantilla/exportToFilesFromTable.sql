-- Write all database images (jpg) to file.
--------- --------- --------- --------- --------- --------- --------- 
DECLARE CURSOR_ProductIds CURSOR FOR (SELECT IDImagen FROM dbo.d_Imagenes)

DECLARE @ProductId INT;

OPEN CURSOR_ProductIds

FETCH NEXT FROM CURSOR_ProductIds INTO @ProductId
WHILE (@@FETCH_STATUS <> -1)
BEGIN
  DECLARE @ImageData varbinary(max);
  SELECT @ImageData = (SELECT convert(varbinary(max), Imagen, 1) FROM dbo.d_Imagenes WHERE IDImagen = @ProductId);

  DECLARE @Path nvarchar(1024);
  SELECT @Path = 'D:\Renier\Work\Goltratec\INCEME2010\centro medico\IncemeDental\Images';

  DECLARE @Filename NVARCHAR(1024);
  SELECT @Filename = (SELECT Descripcion FROM dbo.d_Imagenes WHERE IDImagen = @ProductId);

  DECLARE @FullPathToOutputFile NVARCHAR(2048);
  SELECT @FullPathToOutputFile = @Path + '\' +  RIGHT('00'+ CONVERT(VARCHAR,@ProductId),3)+'_'+ @Filename+'.png';

  DECLARE @ObjectToken INT
  EXEC sp_OACreate 'ADODB.Stream', @ObjectToken OUTPUT;
  EXEC sp_OASetProperty @ObjectToken, 'Type', 1;
  EXEC sp_OAMethod @ObjectToken, 'Open';
  EXEC sp_OAMethod @ObjectToken, 'Write', NULL, @ImageData;
  EXEC sp_OAMethod @ObjectToken, 'SaveToFile', NULL, @FullPathToOutputFile, 2;
  EXEC sp_OAMethod @ObjectToken, 'Close';
  EXEC sp_OADestroy @ObjectToken;

  FETCH NEXT FROM CURSOR_ProductIds INTO @ProductId
END
CLOSE CURSOR_ProductIds
DEALLOCATE CURSOR_ProductIds

