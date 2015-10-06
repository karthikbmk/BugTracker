CREATE proc updateIssueLog
@IssueID varchar(20),
@PrjName varchar(20),
@CRName varchar(20)
as
begin	
	declare @intIssueID int
	begin try
		select @intIssueID = CONVERT(int,@IssueID)
		if exists(select 'x' from master..issueLog(nolock) where IssueID = @intIssueID and PrjName = @PrjName)
		begin
			select 'valid'
			select isnull(IssueDesc,''),isnull(Severity,''),isnull(Status,''),isnull(Developer,''),isnull(Tester,''),isnull(Lead,''),isnull(Remarks,'')
			from master..issueLog(nolock)
			where IssueID = @intIssueID
		end
		else
		begin
			select 'Pls Enter a valid issue number'
		end
	end try
	begin catch
		select 'Pls Enter a valid issue number'
	end catch
end



