create proc getLeads
as
begin
	select isnull(name,'')
	from master..userDetails(nolock)
	where Role = 'Lead'
end
