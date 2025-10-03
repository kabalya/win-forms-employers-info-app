USE TestTaskDb;
GO
CREATE PROCEDURE ListOfPersons
	@SqlCommand NVARCHAR(Max) = NULL,
	@FilterStatus NVARCHAR(100) = NULL,
    @FilterDepartment NVARCHAR(100) = NULL,
    @FilterPost NVARCHAR(100) = NULL, -- Position in company
    @FilterNamePart NVARCHAR(100) = NULL, -- Part of last_name
	@SortBy NVARCHAR(100) = NULL, -- Name of collumn
	@TypeOfSort NVARCHAR(100) = 'ASC' -- ASC|DESC
	AS
BEGIN

SET @SqlCommand= N'
	SELECT (persons.last_name + '' '' + LEFT(persons.first_name,1) + ''.'' + LEFT(persons.second_name,1) + ''. '') AS Name, status.name AS status, deps.name AS department, posts.name AS post, date_employ, date_unemploy
    FROM persons
	JOIN status ON persons.status = status.id
	JOIN deps ON persons.id_dep = deps.id
	JOIN posts ON persons.id_post = posts.id'

	IF @FilterStatus IS NOT NULL
        SET @SqlCommand += ' AND status.name = @FilterStatus';
    IF @FilterDepartment IS NOT NULL
        SET @SqlCommand += ' AND deps.name = @FilterDepartment';
    IF @FilterPost IS NOT NULL
        SET @SqlCommand += ' AND posts.name = @FilterPost';
    IF @FilterNamePart IS NOT NULL AND @FilterNamePart <> ''
        SET @SqlCommand += ' AND persons.last_name LIKE ''%'' + @FilterNamePart + ''%'' ';
	IF @SortBy IS NOT NULL AND (@TypeOfSort = 'ASC' OR @TypeOfSort = 'DESC')
		SET @SqlCommand += ' ORDER BY ' + QUOTENAME(@SortBy) + ' ' + @TypeOfSort;

	EXECUTE sp_executesql @SqlCommand,
        N'@FilterStatus NVARCHAR(100), @FilterDepartment NVARCHAR(100), @FilterPost NVARCHAR(100), @FilterNamePart NVARCHAR(100), @SortBy NVARCHAR(100), @TypeOfSort NVARCHAR(100)',
        @FilterStatus, @FilterDepartment, @FilterPost, @FilterNamePart, @SortBy, @TypeOfSort
	
	PRINT 'SQL result comand' + @SqlCommand

END