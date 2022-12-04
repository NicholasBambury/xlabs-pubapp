# xlabs pubapps test

Sample application is a very simple API, chose to stick with dotnet 6 as LTS, chose not to use minimual APIs to emulate perfered approach for production APIs rather than POCs.

No auth as simple readonly API, however if publically exposed then would need to consider looking into security aspects to protect data and systems from DDOS etc.

No realy design patterns used, could utlise the repository pattern, you might want to only create RESTful APIs.

If read/write API might want to consider CQRS.

APIs would probably want updating to provide more presice error status such depdning on result of service level calls.

## Backend
Repo contains dotnet 6 API
    *Swagger on startup to exercise the API endpoints.
    *Sql Lite DB for data store, to keep it simple for more complex queries, otherwise could have utilsed Azure Table storage if a relatively static data set.
    *Small unit test project.
    *Dockerfile - basic out of the box docker file

## Frontend
Probably looked to create a React SPA application for the frontend.
    *Would have needed to add Cors to API for this
    *Possibly some E2E tests with something like playwright

## Infrastructure
Included a single PR build/test yaml file, but idealy a more complete yaml for PR build but then on merge delpoy to QA with a approval gate to Production.
Depending on system size and setup this could be achieved in single yaml or composite of several yamls for different stages of the pipeline, and a small trigger yaml in the repo itself.

Would add a release docker file for QA/Prod

Look to move logging to Application Insights
Look to utilse Azure App Config for any settings

## How to Run
As the repo is API only currently steps are clone the repo, the project is targeting docker so can be run directly there from Visual Studio and Swagger UI can be used to test the API.
