use DDchar
go
create function fn_characterImport (@charID int)
AS
BEGIN
SELECT *
FROM Character
WHERE CharID = @charID
END
go