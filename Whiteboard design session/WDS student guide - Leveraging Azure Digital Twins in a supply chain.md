![Microsoft Cloud Workshops](https://github.com/Microsoft/MCW-Template-Cloud-Workshop/raw/main/Media/ms-cloud-workshop.png "Microsoft Cloud Workshops")

<div class="MCWHeader1">
Leveraging Azure Digital Twins in a supply chain
</div>

<div class="MCWHeader2">
Whiteboard design session student guide
</div>

<div class="MCWHeader3">
October 2021
</div>

Information in this document, including URL and other Internet Web site references, is subject to change without notice. Unless otherwise noted, the example companies, organizations, products, domain names, e-mail addresses, logos, people, places, and events depicted herein are fictitious, and no association with any real company, organization, product, domain name, e-mail address, logo, person, place or event is intended or should be inferred. Complying with all applicable copyright laws is the responsibility of the user. Without limiting the rights under copyright, no part of this document may be reproduced, stored in or introduced into a retrieval system, or transmitted in any form or by any means (electronic, mechanical, photocopying, recording, or otherwise), or for any purpose, without the express written permission of Microsoft Corporation.

Microsoft may have patents, patent applications, trademarks, copyrights, or other intellectual property rights covering subject matter in this document. Except as expressly provided in any written license agreement from Microsoft, the furnishing of this document does not give you any license to these patents, trademarks, copyrights, or other intellectual property.

The names of manufacturers, products, or URLs are provided for informational purposes only and Microsoft makes no representations and warranties, either expressed, implied, or statutory, regarding these manufacturers or the use of the products with any Microsoft technologies. The inclusion of a manufacturer or product does not imply endorsement of Microsoft of the manufacturer or product. Links may be provided to third party sites. Such sites are not under the control of Microsoft and Microsoft is not responsible for the contents of any linked site or any link contained in a linked site, or any changes or updates to such sites. Microsoft is not responsible for webcasting or any other form of transmission received from any linked site. Microsoft is providing these links to you only as a convenience, and the inclusion of any link does not imply endorsement of Microsoft of the site or the products contained therein.

© 2021 Microsoft Corporation. All rights reserved.

Microsoft and the trademarks listed at <https://www.microsoft.com/en-us/legal/intellectualproperty/Trademarks/Usage/General.aspx> are trademarks of the Microsoft group of companies. All other trademarks are property of their respective owners.

**Contents**

<!-- TOC -->
- [Leveraging Azure Digital Twins in a supply chain whiteboard design session student guide](#leveraging-azure-digital-twins-in-a-supply-chain-whiteboard-design-session-student-guide)
  - [Abstract and learning objectives](#abstract-and-learning-objectives)
  - [Step 1: Review the customer case study](#step-1-review-the-customer-case-study)
    - [Customer situation](#customer-situation)
    - [Customer needs](#customer-needs)
    - [Customer objections](#customer-objections)
    - [Infographic for common scenarios](#infographic-for-common-scenarios)
  - [Step 2: Design a proof of concept solution](#step-2-design-a-proof-of-concept-solution)
  - [Step 3: Present the solution](#step-3-present-the-solution)
  - [Wrap-up](#wrap-up)
  - [Additional references](#additional-references)
<!-- /TOC -->

# Leveraging Azure Digital Twins in a supply chain whiteboard design session student guide

## Abstract and learning objectives

In this whiteboard design session, you will work in a group to evaluate Contoso's goals and design an IoT-based supply chain solution that uses the optimal combination of Azure tools and services that will fulfill their needs. You will also model their physical and logical environment to identify elements along with their properties and define the relationships between them. You will guide Contoso on deploying these models to Azure Digital Twins, how to leverage them and keep them up-to-date.

At the end of this whiteboard design session, you will be better able to design an end-to-end Azure IoT supply chain solution from telemetry ingestion to data insights, all while leveraging Azure Digital Twins.

## Step 1: Review the customer case study

**Outcome**

Analyze your customer's needs.

Timeframe: 15 minutes

Directions: With all participants in the session, the facilitator/SME presents an overview of the customer case study along with technical tips.

1. Meet your table participants and trainer.

2. Read all of the directions for steps 1-3 in the student guide.

3. As a table team, review the following customer case study.

### Customer situation

Contoso Apparel is a large multinational clothing manufacturer. Their environment consists of several factories, warehouses, storefronts, and logistics infrastructure. Multiple telemetry points are measured to ensure the highest quality level in their products, such as temperature, vibration, location, and humidity. Of these readings, maintaining humidity within the range of X and Y at all supply chain levels is the most critical. Due to mold issues, humidity has a direct correlation to the quality of the delivered consumer end-product.

Contoso Apparel is looking to implement an end-to-end IoT solution in Azure. They will need data ingestion, processing, storage, and visualization. For the proof of concept, they wish to track humidity levels at each level of their supply chain to ensure a high-quality consumer product.

Contoso desires to model and visualize the relationship between their processes, products, equipment, factories, shipping logistics, warehouses, and storefronts. They wish to have the ability to query into the current state of each of these elements defined their supply chain environment. They would also like to analyze historical data to track successful product deliveries or determine the root cause of unsuccessful deliveries. They also wish to leverage these models to simulate potential 'what if' process changes and assess their overall impact without experimenting with or impacting the current supply chain.

In this proof of concept project, Contoso Apparel also wants to improve resiliency and time to recover at their factories by automating mitigating measures should an anomalous event occur. For example, product manufacturing could be re-routed to a secondary 'failover' factory should there be a moisture problem at the original facility. Currently, this type of failover is a manual, lengthy, and error-prone process that involves updating several systems and configuration files.

### Customer needs

1. We would like to model our supply chain environment in order to gain insight into the elements along with their properties, components and the relationships between them.

2. We need monitor humidity telemetry from our factories in near real-time for anomalies between the values of X and Y. What services can we put in place so that we can quickly be alerted when this happens?

3. We would like the ability to re-route manufacturing to a different facility should there be a moisture problem at a factory.

4. We need the ability to query the current state of our supply chain elements.

5. We need the ability to review historical trends in data to identify what is working well as well as for root cause analysis of problems. We need to be able to perform ad-hoc queries on this data and obtain customized chart visualizations.

### Customer objections

1. Authoring Digital Twin Definition Language (DTDL) documents for all of our supply chain elements sounds like an enormous and complex undertaking. We don't even know how to get started with this. What do you recommend as a starting point?

2. Our supply chain is a continuously running system, 24 hours a day, 7 days a week. As such, the state of each of our elements is in a constant state of change. How can we ensure the accuracy of our digital models? How will these be kept up-to-date?

3. We want to track a manufactured product such as a T-Shirt from its manufacturing on a factory floor, delivery to a warehouse, then to a store. Finally, we'd like to trace the T-Shirt through its purchase at a store by a customer. Is this level of tracing even possible?

### Infographic for common scenarios

Azure Digital Twins is commonly used in combination with other Azure services as part of a larger IoT solution. A complete solution using Azure Digital Twins may contain the following parts:

1. The Azure Digital Twins service instance. This stores your twin models and your twin graph with its state, and orchestrates event processing.

2. One or more client apps that drive the Azure Digital Twins instance by configuring models, creating topology, and extracting insights from the twin graph.

3. One or more external compute resources to process events generated by Azure Digital Twins, or connected data sources such as devices. One common way to provide compute resources is via Azure Functions.

4. An IoT hub to provide device management and IoT data stream capabilities.
Downstream services to handle tasks such as workflow integration (like Logic Apps, cold storage, time series integration, or analytics).

![Azure Digital Twins and associated graph is central to interactivity with inputs of workflow integration, IoT hub, and REST APIs; outputs of workflow integration, storage, Time Series insights and analytics systems. Azure Digital Twins is shown also integrating with client apps to manage models and the graph as well as Azure Functions for external compute handling of business logic and data processing.](media/infographic.png "Infographic for common scenarios")

## Step 2: Design a proof of concept solution

**Outcome**

Design a solution and prepare to present the solution to the target customer audience in a 15-minute chalk-talk format.

Timeframe: 60 minutes

**Business needs**

Directions:  With all participants at your table, answer the following questions and list the answers on a flip chart:

1. Who should you present this solution to? Who is your target customer audience? Who are the decision makers?

2. What customer business needs do you need to address with your solution?

**Design**

Directions: With all participants at your table, respond to the following questions on a flip chart:

*High-level architecture*

1. Without getting into the details (the following sections will address the details), diagram your initial vision for handling the top-level requirements for environment modeling, data ingestion and monitoring, model updates, business logic implementation, and data visualization.

*Environment modeling*

1. As a starting point, how do you recommend Contoso Apparel approach modeling entities in their environment?

2. At a high level, what types of information should be encapsulated within an entity definition?

3. What methods are available for Contoso to add these entities to their environment knowledge graph?

4. How would Contoso query and visualize the knowledge graph representation of their environment model?

*Data ingestion and monitoring*

1. Which Azure service(s) should Contoso use to register and authenticate their IoT devices?

2. How should the IoT telemetry data be ingested into Azure?

3. How would Contoso Apparel monitor for humidity anomalies in near real-time?

4. Which Azure service(s) would you recommend so that Contoso Apparel can receive the humidity anomaly notification?

*Model updates*

1. How do you suggest keeping the environment model up-to-date with the real world state?

*Business logic implementation*

1. How do you suggest implementing failover in the event that a factory needs to be taken offline for maintenance?

*Data visualization*

1. Contoso apparel needs to be able to perform ad-hoc queries and visualize historical data. What Azure service(s) would you suggest for this?

**Prepare**

Directions: With all participants at your table:

1. Identify any customer needs that are not addressed with the proposed solution.

2. Identify the benefits of your solution.

3. Determine how you will respond to the customer's objections.

Prepare a 15-minute chalk-talk style presentation to the customer.

## Step 3: Present the solution

**Outcome**

Present a solution to the target customer audience in a 15-minute chalk-talk format.

Timeframe: 30 minutes

**Presentation**

Directions:

1. Pair with another table.

2. One table is the Microsoft team and the other table is the customer.

3. The Microsoft team presents their proposed solution to the customer.

4. The customer makes one of the objections from the list of objections.

5. The Microsoft team responds to the objection.

6. The customer team gives feedback to the Microsoft team.

7. Tables switch roles and repeat Steps 2-6.

## Wrap-up

Timeframe: 15 minutes

Directions: Tables reconvene with the larger group to hear the facilitator/SME share the preferred solution for the case study.

## Additional references

|    |            |
|----------|:-------------:|
| **Description** | **Links** |
| Azure Solution Architectures | [https://azure.microsoft.com/en-us/solutions/architecture/](https://azure.microsoft.com/en-us/solutions/architecture/) |
| Azure Digital Twins documentation   | [https://docs.microsoft.com/en-us/azure/digital-twins/](https://docs.microsoft.com/en-us/azure/digital-twins/)  |
| Azure Digital Twins learning path | [https://docs.microsoft.com/en-us/learn/paths/develop-azure-digital-twins/](https://docs.microsoft.com/en-us/learn/paths/develop-azure-digital-twins/)  |
| Digital Twin Definition Language (DTDL) | [https://docs.microsoft.com/en-us/azure/digital-twins/concepts-models](https://docs.microsoft.com/en-us/azure/digital-twins/concepts-models) |
| DTDL Specification | [https://github.com/Azure/opendigitaltwins-dtdl/blob/master/DTDL/v2/dtdlv2.md](https://github.com/Azure/opendigitaltwins-dtdl/blob/master/DTDL/v2/dtdlv2.md) |
| Azure Digital Twins Ontologies | [https://docs.microsoft.com/en-us/azure/digital-twins/concepts-ontologies](https://docs.microsoft.com/en-us/azure/digital-twins/concepts-ontologies) |
| Azure Digital Twins Explorer | [https://docs.microsoft.com/en-us/samples/azure-samples/digital-twins-explorer/digital-twins-explorer/](https://docs.microsoft.com/en-us/samples/azure-samples/digital-twins-explorer/digital-twins-explorer/) |
| Azure Digital Twins Explorer (Preview) | [https://docs.microsoft.com/en-us/azure/digital-twins/concepts-azure-digital-twins-explorer] |
| Azure Stream Analytics anomaly detection  | [https://docs.microsoft.com/en-us/azure/stream-analytics/stream-analytics-machine-learning-anomaly-detection](https://docs.microsoft.com/en-us/azure/stream-analytics/stream-analytics-machine-learning-anomaly-detection)  |
| Azure IoT Hub Device Provisioning Service  | [https://docs.microsoft.com/en-us/azure/iot-dps/](https://docs.microsoft.com/en-us/azure/iot-dps/)   |
| Azure IoT Hub documentation | [https://docs.microsoft.com/en-us/azure/iot-hub/](https://docs.microsoft.com/en-us/azure/iot-hub/) |
| Azure Time Series Insights documentation | [https://docs.microsoft.com/en-us/azure/time-series-insights/](https://docs.microsoft.com/en-us/azure/time-series-insights/) |
| Azure Logic Apps documentation | [https://docs.microsoft.com/en-us/azure/logic-apps/](https://docs.microsoft.com/en-us/azure/logic-apps/) |
| Azure Digital Twins query plugin for Azure Data Explorer | [https://docs.microsoft.com/en-us/azure/digital-twins/concepts-data-explorer-plugin] |
