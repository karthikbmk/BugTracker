CREATE proc issuelogDel
@IssueID varchar(10),
@Project varchar(20)
as
begin
	
	begin try
		select @IssueID = REPLACE(@IssueID,'''','')
		select @IssueID = CONVERT(int,@issueID)
		
		if exists(select 'x' from master..issueLog(nolock) where IssueID = @IssueID and PrjName = @Project)
		begin
			delete from master..issueLog where IssueID = @IssueID	and PrjName = @Project		
			select 'Delete success.Pleas reload'
			return
		end
		else
		begin
			select 'Invalid IssueID'
			return
		end
	end try
	begin catch
		select 'Invalid IssueID'
		return
	end catch
	select 'Invalid IssueID'
end


