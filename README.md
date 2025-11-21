**EventEaseApp** 🎉

A Blazor WebAssembly application for managing event registrations and attendance with a clean, responsive UI. EventEaseApp demonstrates modern .NET development practices, component reuse, and accessible design — perfect for organizers and participants alike.

**🚀 Features**

Event registration: Users can sign up for events with name and email.

Attendance tracking: View who’s registered and manage cancellations.

Custom table styling: Alternating row colors, hover effects, and smooth transitions for readability.

Responsive layout: Panels, grid, and keypad adapt seamlessly to mobile and desktop.

Reusable components: Built with Blazor’s component model for maintainability.

Accessible design: Semantic markup, clear contrast, and keyboard-friendly inputs.

**🛠️ Tech Stack**

Blazor WebAssembly — client-side .NET app framework

.NET 8 — modern runtime and tooling

Bootstrap 5 — responsive styling and layout

Custom CSS — branded look with transitions and hover effects

GitHub Actions — automated deployment to GitHub Pages (optional)

**📂 Project Structure**

Code

EventEaseApp/
├── Pages/
│   ├── Index.razor
│   ├── Register.razor
│   └── Registrations.razor
├── Components/
│   ├── NavMenu.razor
│   └── AttendanceTable.razor
├── Services/
│   └── RegistrationService.cs
├── wwwroot/
│   ├── css/
│   │   └── app.css
│   └── index.html
└── README.md

**⚙️ Getting Started**

Prerequisites

Install .NET SDK

Install Visual Studio Code or Visual Studio

Run locally:

bash
git clone https://github.com/rtcn2/eventeaseapp.git
cd eventeaseapp
dotnet run
Open https://localhost:5001 in your browser.

**🌐 Deployment**

EventEaseApp can be deployed to GitHub Pages or Azure Static Web Apps.

For GitHub Pages:

Publish with dotnet publish -c Release -o publish

Push publish/wwwroot to the gh-pages branch

Enable Pages in repo settings

**👩‍💻 Author**

Built by AlexandraPlRo — strategic communicator turned developer, blending investigative rigor with modern .NET craftsmanship.

