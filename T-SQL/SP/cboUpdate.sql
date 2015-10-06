CREATE proc cboUpdate
as
begin
	select sc.name
	from sys.sysobjects so(nolock)
		 inner join
		 sys.syscolumns sc(nolock)
	on so.id = sc.id
	where so.name = 'issuelog'	
	and sc.name <> 'IssueID' 
end	
