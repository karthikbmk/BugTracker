CREATE PROC getProjects
as
begin
	select isnull(PrjName,'')
	from master..ftiProjects
end
