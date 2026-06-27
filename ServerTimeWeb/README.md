# ServerTimeWeb - ASP.NET Core Razor Pages App

A high-fidelity ASP.NET Core Razor Pages web application that retrieves the server's local date and time and renders it dynamically in the browser with premium glassmorphism styling and a live real-time ticking script.

---

## 1. Core C# & Razor Pages Concepts Explored

As part of this assignment, we explored and integrated several essential C# and ASP.NET Core MVC/Razor Pages concepts:

### DateTime.Now
- **Definition**: A built-in C# property (`System.DateTime.Now`) that gets a `DateTime` object set to the current date and time on this computer, expressed as the local time.
- **Usage in App**: We call `DateTime.Now` inside the page's controller/model to fetch the server time when a client requests the page, formatting it into a clean, readable string.

### Event Handler
- **Definition**: A delegate method or code block that is executed in response to a specific event occurring (such as a button click, database update, or page lifecycle stage).
- **Usage in App**: The browser execution model leverages event handlers (like timer intervals and reload button actions) to handle interactive user events.

### Razor Pages Handler Methods (`OnGet` & `OnPost`)
- **Definition**: Special methods in Razor Page Models (derived from `PageModel`) that handle specific HTTP requests based on verb naming conventions.
- **OnGet()**: Automatically executes when the browser requests the page using a `GET` request (e.g., initial page load or link navigation). In our app, we use it to calculate the initial server time.
- **OnPost()**: Automatically executes when a form is submitted using a `POST` request, allowing backend form processing.

### void
- **Definition**: A C# keyword used in method signatures to state that the method executes its logic but does not return any value back to the caller.
- **Usage in App**: Both `OnGet()` and `OnPost()` in Page Models commonly return `void` when they only initialize state variables (like setting our `ServerTime` string) rather than returning an `IActionResult` redirect.

---

## 2. Local Setup & Execution

### Prerequisites
- .NET 8.0 SDK installed.

### How to Run Locally
1. Navigate to the project directory:
   ```bash
   cd ServerTimeWeb
   ```
2. Build the project:
   ```bash
   dotnet build
   ```
3. Run the development server:
   ```bash
   dotnet run
   ```
4. Open your browser and navigate to `http://localhost:5000` or the HTTPS URL printed in the console.

---

## 3. Azure Free Tier Deployment Guide

Follow these step-by-step instructions to publish your web application to Azure completely for free:

### Step 1: Create a Free Azure Account
1. Go to the [Azure Free Portal](https://azure.microsoft.com/free/).
2. Click **Start free** and sign in with a Microsoft account.
3. Complete the registration. You will receive 12 months of popular free services, $200 credit for the first 30 days, and **always-free** services (including App Service).

### Step 2: Create a Free App Service Slot in the Azure Portal
1. Sign in to the [Azure Portal](https://portal.azure.com/).
2. In the search bar at the top, type **App Services** and select it.
3. Click **+ Create** -> **Web App**.
4. Configure the Instance Details:
   - **Subscription**: Select your Free subscription.
   - **Resource Group**: Click *Create new* (e.g., `ServerTimeGroup`).
   - **Name**: Enter a unique name (e.g., `servertime-yourname`).
   - **Publish**: Select *Code*.
   - **Runtime stack**: Select `.NET 8 (LTS)`.
   - **Operating System**: Select *Windows* (or Linux).
   - **Region**: Select a region close to you (e.g., *East US*).
5. Configure the Hosting Plan:
   - Under **Pricing plan**, click *Explore pricing plans* or *Change size*.
   - **CRITICAL**: Select the **F1 (Free)** tier under the *Dev/Test* tab. This tier provides 60 minutes of compute time per day for free and guarantees zero charges.
6. Click **Review + create**, then click **Create**. Wait for the deployment to finish.

### Step 3: Deploy using Git Integration (Simplest & Free)
1. Go to your Web App resource page in the Azure Portal.
2. In the left menu under *Deployment*, select **Deployment Center**.
3. Under *Source*, select **Local Git**. Click **Save**.
4. Azure will generate a Git Clone URI. Copy this URI.
5. In the left menu under *Deployment*, select **Deployment Center** -> **FTPS Credentials** (or Local Git credentials) to set a username and password for Git deployment.
6. Open your local terminal in the `ServerTimeWeb` directory and add the Azure remote:
   ```bash
   git remote add azure <YOUR_AZURE_GIT_CLONE_URI>
   ```
7. Push the code to Azure to trigger a build and deploy:
   ```bash
   git push azure main:master
   ```
8. Enter your deployment credentials when prompted. Once complete, your site will be live at `https://<your-app-name>.azurewebsites.net`!
