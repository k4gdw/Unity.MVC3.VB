Imports Microsoft.Practices.Unity
Imports System.Web.Mvc
Imports Unity.MVC3

Public NotInheritable Class Bootstrapper
	Private Sub New()
	End Sub
	Public Shared Sub Initialise()
		Dim container = BuildUnityContainer()

		DependencyResolver.SetResolver(New UnityDependencyResolver(container))
	End Sub

	Private Shared Function BuildUnityContainer() As IUnityContainer
		Dim container = New UnityContainer()

		' register all your components with the container here
		' e.g. container.RegisterType<ITestService, TestService>();            

		container.RegisterControllers()

		Return container
	End Function
End Class

