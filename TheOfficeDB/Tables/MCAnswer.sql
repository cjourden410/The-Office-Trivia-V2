CREATE TABLE [dbo].[MCAnswer]
(
	[answer_id] INT NOT NULL PRIMARY KEY Identity, 
    [choice] NVARCHAR(100) NOT NULL, 
    [question_id] INT NOT NULL, 
    [is_correct] BIT NOT NULL, 
    CONSTRAINT [FK_MCAnswer_Question] FOREIGN KEY (question_id) REFERENCES [Question]([question_id])
)
