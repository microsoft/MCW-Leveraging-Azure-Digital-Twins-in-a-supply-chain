# Leveraging Azure Digital Twins in a supply chain

## This workshop is archived and no longer being maintained.  Content is read-only.

Azure Digital Twins (ADT) is a platform as a service (PaaS) offering that enables creating knowledge graphs based on digital models of entire environments. These environments could be buildings, factories, farms, energy networks, railways, stadiums, and more—even entire cities. These digital models can help gain insights that drive better products, optimized operations, reduced costs, and breakthrough customer experiences. Azure Digital Twins facilitates asset connectivity, such as connecting IoT devices with existing business systems. ADT also offers a robust event system to build dynamic business logic and data processing. Integrate with Azure data, analytics, and AI services to help you track the past and then predict the future, all in a scalable and secure manner.

Contoso Apparel is a large multinational clothing manufacturer. Their environment consists of several factories, warehouses, storefronts, and logistics infrastructure. Multiple telemetry points are measured to ensure the highest quality level in their products, such as temperature, vibration, location, and humidity. Of these readings, maintaining humidity within the range of x and y at all supply chain levels is the most critical. Due to mold issues, humidity has a direct correlation to the quality of the delivered consumer end-product. Contoso Apparel is looking to implement digital twins to model their existing supply chain environment end-to-end so that they can visualize their entire environment and gain insight into the current state of their assets.

October 2021

## Target audience

- Application developer

- IoT developer

## Abstracts

### Workshop

In this workshop, you will learn how to interpret and author Digital Twin Definition Language (DTDL) documents to model a supply chain environment. Using the Digital Twins Explorer, you will visualize and query the knowledge graph consisting of defined digital twins. Through device simulation, realistic telemetry is generated and ingested into an Azure IoT hub where Azure Stream Analytics will monitor for humidity anomalies. You will also integrate Azure Digital Twins with Azure Time Series Insights that will assist in visualizing historical and present data. Lastly, you will leverage Azure Digital Twins to implement factory failover using event routing.

At the end of this workshop, you will be better able to explain the benefits of Azure Digital Twins as well as architect an analytical IoT solution.

### Whiteboard design session
In this whiteboard design session, you will work in a group to evaluate Contoso's goals and design an IoT-based supply chain solution that uses the optimal combination of Azure tools and services that will fulfill their needs. You will also model their physical and logical environment to identify elements along with their properties and define the relationships between them. You will guide Contoso on deploying these models to Azure Digital Twins, how to leverage them and keep them up to date.

At the end of this whiteboard design session, you will be better able to design an end-to-end Azure IoT supply chain solution from telemetry ingestion to data insights, all while leveraging Azure Digital Twins.

### Hands-on lab
In this hands-on lab, you will implement an Azure IoT solution for a supply chain scenario. You will learn to interpret and author Digital Twin Definition Language (DTDL) that models physical and logical elements of an environment. You will use DTDL to represent an element's properties, telemetry, components, and relationships. Next, you will learn how to deploy the models into Azure Digital Twins and visualize them using Azure Digital Twins Explorer. You will learn how to leverage Azure Digital Twins by deploying an end-to-end IoT solution, including identifying anomalies and automating automatic failover of factory work using eventing.

At the end of this hands-on lab, you will be better able to implement an end-to-end Azure IoT supply chain solution from telemetry ingestion to data insights, all while leveraging Azure Digital Twins.

## Azure services and related products
- Azure Digital Twins
- Azure Digital Twins Explorer
- Azure IoT Hub
- Azure Functions
- Azure Stream Analytics
- Azure Logic Apps
- Azure Event Hub
- PowerShell

## Related references
- [MCW](https://microsoftcloudworkshop.com/)
- [Azure Digital Twins documentation](https://docs.microsoft.com/en-us/azure/digital-twins/)
- [Azure Digital Twins learning path](https://docs.microsoft.com/en-us/learn/paths/develop-azure-digital-twins/)

## Help & Support

We welcome feedback and comments from Microsoft SMEs & learning partners who deliver MCWs.  

***Having trouble?***
- First, verify you have followed all written lab instructions (including the Before the Hands-on lab document).
- Next, submit an issue with a detailed description of the problem.
- Do not submit pull requests. Our content authors will make all changes and submit pull requests for approval.  

If you are planning to present a workshop, *review and test the materials early*! We recommend at least two weeks prior.

### Please allow 5 - 10 business days for review and resolution of issues.
