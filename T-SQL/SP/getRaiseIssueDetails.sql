CREATE proc getRaiseIssueDetails
@IssueId varchar(20)
as
begin
	declare @intIssueId int
	begin try	
		select @intIssueID = convert(int,@IssueId)		
		if exists(select 'x' from master..issueLog(nolock) where IssueID = @intIssueId)
		begin
			select IssueID as IssueID,PrjName as PrjName,CRName as CRName,IssueDesc as IssueDesc,Severity as Severity,Status as Status,lower(Developer) as Developer,Remarks as Remarks, Lead as lead from master..issueLog(nolock)  where IssueID = @intIssueId
		end
		else
		begin
			select 'Issue ID doesn''t exist..','NNN'
		end
	end try
	begin catch
		select 'pls give nos boss..','NNN'
	end catch
end




