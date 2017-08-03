# Template Questions

Each question may belong to a "templated question". A survey is made up of a series of questions of which each may or may not be linked to a templated question. Queries are executed against templated questions to return all reponses from all surveys to that question.

## Pros
* Extreemely Flexible. Authors can create surveys that have a mix of templated and non templated questions.
* Easy to provide slightly different language per question per survey and still corrolate answers (if desired).
* The same queries defined in TemplateSurveys could be run against a group of questions.
* One-off surveys are trivial
* Allows different questions to be included in a single survey, such as common demographic questions, user trends, and course specific data.


## Cons
* No direct requirement that questions be templated questions. This means that it is possible to create a new question that should match up to a templated question, but has not be specified to. This can be avoided by adding Azure Search service to check the question text and recommend appriopriate templated questions that should be linked.

## Example

Survey -> Questions (each of which may or may not belong to a templated question)

### Survey
* SurveyID - Survey1
* Questions : of type Question

### Templated Question
* ID - TemplateQuestion1
* Text - Did you enjoy the course?
* AvailableResponses - Loved it, liked it, hated it

### Question
* ID - Question1
* TemplateQuestionId - TemplateQuestion1
* AvailableReponses - (inherit from template question)
* Text - (inherit from template question, can optionally override)

### Query
In this system queries are executed against TemplatedQuestions

```sql
SELECT * FROM Answers WHERE TemplateQuestionId in (@QuestionIds)
```
