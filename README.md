# Example for hosting WCF service in Windows service

This article demonstrates the required steps to host your WCF service in Windows Service and consume it in a console application.

Hosting WCF service to Windows service gives you the following benefits.

1. Service will be automatically started whenever the hosting computer starts. Service can be manually started, stop, or restart.
1. Service will always be activated and available for clients. No need for runtime activation.
1. Windows Administrators already know managing Windows services.
1. Provides an extra layer of security through windows identity.
1. Gives better performance than service hosted in IIS.
1. Gives you the flexibility to choose any bindings.


## Applications

1. **[WCF Service](https://github.com/geeksarray/example-for-hosting-wcf-service-in-windows-service/tree/master/Northwind%20Services/NorthwindServices)** - WCF Service with 
    IProduct Service Contract exposed.
    
1. **[Windows Service hosting WCF Service](https://github.com/geeksarray/example-for-hosting-wcf-service-in-windows-service/tree/master/Northwind%20Services/NorthwindHost)** -
   Windows service hosting Product WCF Service.
   
![Install Windows Service](https://geeksarray.com/images/blog/installutil.png)

For more detailed description visit - https://geeksarray.com/blog/example-for-hosting-wcf-service-in-windows-service
