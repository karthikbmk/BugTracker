create proc getResources
as
begin
	select isnull(Name,'')
	from master..userDetails(nolock)
	where Role = 'Resource'
end
	
