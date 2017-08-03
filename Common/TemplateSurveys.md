# Template Surveys

Each survey belongs to one template. The template identifies the questions in the survey. This ensures an identical set of references to questions. Queries are executed against a survey template to return all reponses to all surveys using that template.

## Pros
* Simple to implement
* Very easy to query

## Cons
* Rigid, Inflexible - If a content author wants to add a single new question to a templated survey they would be unable to without creating an entirely new template. This may inadvertantly create duplicate questions.
* One-off surveys- One off surveys can't be done without creating an entirely new template each time.

## Example

Survey -> SurveyTemplate -> Questions

## Survey
* SurveyId - Survey1
* SurveyTemplateId - SurveyTemplate1

## SurveyTemplate
* SurveyTemplateID - SurveyTemplate1
* Questions : of type Question

### Question
* ID - Question1
* AvailableReponses
* Text

### Query
In this system queries are executed against SurveyTemplates

```sql
SELECT 
    *
FROM 
    Answers a
JOIN
    SurveyTemplateQuestions st on st.QuestionId = a.QuestionId
WHERE
    SurveyTemplateId = 'SurveyTemplate1'
```