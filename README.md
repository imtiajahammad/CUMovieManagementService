# CUMovieManagementService

We are going to create 3 projects.
    The first one is going to be the API which is going to provide endpoint to the client
    The second project will be our domain. Our domain is going to store the model class and our interfaces.The domain will be responsible for the business logic of our application.
    Then the third project is going to be data access. This will make the actual read/write requests to the database operation.



#Entity_Framework_Relationships:
        There are 4 Entities-
                            1. Actor
                            2. Biography
                            3. Genre
                            4. Movie
        One to One Relationship: Actor-Biography => Actor can only have one Biography
                                 Movie-Actor => One movie can only have 1 actor

        One to Many Relationship: Actor-Movie => Actor can have many movies

        Many to Many Relationship: Movie-Genre -> Every movie can be consist of multiple genre and vice-versa

                                        



#Migrations:
    Select MovieManagement.DataAccess -
                    1. Open terminal from visual studio or from scrach, go to ../MovieManagement.DataAccess directory
                    2. Use this- dotnet ef migrations add CreatingDb --context MovieManagementDbContext -p ../MovieManagement.DataAccess/MovieManagement.DataAccess.csproj -s ../MovieManagement.API/MovieManagement.API.csproj -o ../MovieManagement.DataAccess/Migrations/MovieManageMentDbContext
                    3. use this - dotnet ef database update CreatingDb --project ../MovieManagement.DataAccess/MovieManagement.DataAccess.csproj -s ../MovieManagement.API/MovieManagement.API.csproj -c MovieManagementDbContext


Reference: https://www.youtube.com/watch?v=xdibesoH8zE&list=WL&index=311&ab_channel=CodeUnparalleled

