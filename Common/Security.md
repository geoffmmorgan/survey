# Security

## Description
All security should be provided via AAD. This login should pass through to the API all the way to the database to allow proper auditing.

Only authorized users can use SurveyAdmin.

### Roles

* *God Users* - Have full access to all parts of the system; can identify adminstrators
* *Administrators* - can create and deploy template surveys; add/remove/modify users; modify/close/delete surveys
* *Standard Users* - can design and administer one

Able to identify specific people who act as administrators that have full control of Survey Collector infrastructure; administrators are the only ones who can create and deploy template surveys; they can add/remove standard users; they can modify, close, or delete any survey in the tool.  Administrators grant standard users permission to access the tool (and can remove that permission); one or two people will be granted “godlike” power and be able to identify “administrators”). Administrators have full control over templates and any other survey in the tool, meaning that they can create, modify, deploy, close, delete any survey or template. Administrators should be able to close or delete multiple surveys at one time; a message should appear before surveys are deleted to confirm the action. Administrators have access to all surveys in the tool.

Standard users can design and administer one-off surveys, but they cannot make changes to templatized surveys, only administrators can do that. Standard users can create one-off surveys, which they can create, modify, deploy, and close; standard users only have access to the surveys that they created unless someone has shared a survey with them. 

Standard users can grant other standard users with permission to access their survey. Ideally, they could identify which permissions to grant (“view only,” “edit,” “deploy,” “close”), but this is low priority requirement.



## Questions
1. Is there an existing AAD Tenant to connect to?
1. If the is not, is a social MS account login acceptable?