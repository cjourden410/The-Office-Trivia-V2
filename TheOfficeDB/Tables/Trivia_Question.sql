CREATE TABLE [dbo].[Trivia_Question]
(
	[trivia_id] INT NOT NULL, 
    [question_id] INT NOT NULL, 
    CONSTRAINT [PK_Trivia_Question] PRIMARY KEY ([trivia_id], [question_id]), 
    CONSTRAINT [FK_Trivia_Question_Trivia] FOREIGN KEY (trivia_id) REFERENCES [Trivia]([trivia_id]), 
    CONSTRAINT [FK_Trivia_Question_Question] FOREIGN KEY (question_id) REFERENCES [Question]([question_id]) 
)
