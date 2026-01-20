namespace dev_portfolio.Components.Data
{
    public class ProjectService
    {
        public List<Project> GetProjects()
        {
            return
            [
                new Project
                {
                    Title = "Project One",
                    Description = "A web application for tracking personal fitness goals.",
                    Technologies = ["Blazor", "C#", ".NET", "SQL Server"],
                    ImageUrl = "https://via.placeholder.com/300x200",
                    RepoUrl = "https://github.com/johndoe/project-one",
                    LiveUrl = "https://project-one.johndoe.com"
                },
                new Project
                {
                    Title = "Project Two",
                    Description = "A mobile app for managing recipes and grocery lists.",
                    Technologies = ["MAUI", "C#", ".NET", "SQLite"],
                    ImageUrl = "https://via.placeholder.com/300x200",
                    RepoUrl = "https://github.com/johndoe/project-two",
                    LiveUrl = "https://project-two.johndoe.com"
                },
                new Project
                {
                    Title = "Project Three",
                    Description = "An e-commerce website for selling handmade crafts.",
                    Technologies = ["ASP.NET Core MVC", "C#", ".NET", "Stripe"],
                    ImageUrl = "https://via.placeholder.com/300x200",
                    RepoUrl = "https://github.com/johndoe/project-three",
                    LiveUrl = "https://project-three.johndoe.com"
                }
            ];
        }
    }
}
