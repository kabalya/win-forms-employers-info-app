USE TestTaskDb;
GO
CREATE PROCEDURE UnemployedStatisticPerDay
	@StatusName NVARCHAR(100),
    @StartDate DateTime,
    @EndDate DateTime
AS
BEGIN

	SELECT CONVERT(datetime, p.date_unemploy) AS firing_date, COUNT(*) AS fired_count
		FROM persons p
	JOIN status s ON p.status = s.id
	WHERE s.name = @StatusName
		AND p.date_unemploy IS NOT NULL
		AND p.date_unemploy BETWEEN @StartDate AND @EndDate
	GROUP BY CONVERT(datetime, p.date_unemploy)
	ORDER BY firing_date;

END