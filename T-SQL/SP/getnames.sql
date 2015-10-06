create proc getNames
as
begin
	select isnull(name,'')
	from userDetails(nolock)
end

