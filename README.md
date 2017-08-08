Unity.MVC3.VB
=============

This is a VB.Net version of the Bootstrapper found in the Unity.Mvc3
package available from  NuGet. It depends on my  [Unity.Mvc3.DLL][1]
package which I created to make it easier for developers to use with
other .Net languages without polluting their projects with .cs files
that they end up having to delete.

Bryan Johns, bjohns@greendragonweb.com

Getting started with Unity.Mvc3
-------------------------------

To get started, just add a call to Bootstrapper.Initialise() in  the
Application_Start method  of Global.asax.vb  and  the MVC  framework
will  then use  the  Unity.Mvc3  DependencyResolver to  resolve your
components.

There is code in the bootstrapper to initialise the Unity  container
and register  all  the  controllers  in  the  current assembly.  Any
components  that  you need  to  inject  should be registered in  the
BuildUnityContainer method of the Bootstrapper.  All components that
implement the IDisposable interface should  be  registered  with the
HierarchicalLifetimeManager to ensure that  they are  disposed of at
the end of the request.

[Click here][2] to find out more about Unity.Mvc3.

--------------------------------------------------------------------    
***Last Edit:** Tuesday, August 8, 2017 - 02:01 PM*

[1]: http://k4gdw.us/2vKvYrK "Unity.Mvc3.DLL"
[2]: http://k4gdw.us/2vKvL7B "Devtrends article about Unity.Mvc3"