# Deployment

## Description

The survey runtime should be able to be included into any html based application

## Possible solutions

1. NPM package - Probably a non-starter for EDX Courses
1. Inclusion via a script

```html
<script type="text/javascript" src="https://survey.microsoft.com/loader.js"></script>
<script type="text/javascript">
    var survey = new MSSurvey();
    survey.showSurvey('1234-4567-8953', 'user1', 'other data');
</script>
```

## Questions

1. Is using Angular 4 inside of an existing application going to cause issues? (bootstrapping, DI, etc)