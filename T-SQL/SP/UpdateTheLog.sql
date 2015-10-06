create proc UpdateTheLog
@IssueId varchar(10),
@IssueDesc varchar(max),
@Severity varchar(20),
@Status varchar(20),
@Developer varchar(20),
@Tester varchar(30),
@Lead varchar(30),
@Remarks varchar(max)
as
begin
	if exists (select 'x' from master..issueLog(nolock) where IssueID = CONVERT(int,@IssueId))	
	begin
		update master..issueLog
		set IssueDesc = ISNULL(@IssueDesc,''),
			Severity  = ISNULL(@Severity,''),
			Status    = ISNULL(@Status,''),
			Developer = ISNULL(@Developer,''),
			Tester    = ISNULL(@Tester,''),
			Lead      = ISNULL(@Lead,''),
			Remarks   = ISNULL(@Remarks,'')
		where IssueID = @IssueId
		
		select 'Success.Please Reload.'
	end
	else
	begin
		select 'Failure.'
	end
end
