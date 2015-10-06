CREATE proc getProjectCRs
@projectName varchar(100)
as
begin
	select isnull(crname,'')
	from master..projectcrs(nolock)
	where prjname = ISNULL(@projectName,'')	OR	
		  CRName = ''
end


