USE TestTaskDb;
GO
CREATE PROCEDURE EmployedStatisticPerDay
	@StatusName NVARCHAR(100),
    @StartDate DateTime,
    @EndDate DateTime
AS
BEGIN

	SELECT CONVERT(datetime, p.date_employ) AS hiring_date, COUNT(*) AS hired_count
		FROM persons p
	JOIN status s ON p.status = s.id
	WHERE s.name = @StatusName
		AND p.date_employ IS NOT NULL
		AND p.date_employ BETWEEN @StartDate AND @EndDate
	GROUP BY CONVERT(datetime, p.date_employ)
	ORDER BY hiring_date;

END