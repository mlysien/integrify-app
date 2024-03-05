# Integrify

![alt text](https://i.ibb.co/mF5cpfX/banner.png)

# About
Infrastructure layer between ERP systems and e-commerce systems. Can be use for synchronization orders, customers, products and stock form the connected systems.

> [!NOTE]  
> Project is participating in the [100commitow](https://100commitow.pl/ "100commitow.pl") competition.

# Core features
- [ ] Orders synchronization
- [ ] Customers synchronization
- [ ] Products synchronization 
- [ ] Stock status synchronization
- [ ] Creating orders documents (receipt/invoice)
- [ ] Logging of synchronization process
- [ ] Synchronization time scheduling
- [ ] Synchronization direction management (Shop <-> ERP) 

# Nice to have features
- [ ] CLI for management synchronization
- [ ] GUI for preview synchronization process

# Concept
![Test Image 1](/docs/integrify.drawio.concept.png)

# Architecture
> **Modular Monolith architecture** because it is important to separate business logic to a separated modules. Synchronization process should not be dependent on erp/ecommerce system.

# License
[![MIT License](https://img.shields.io/badge/License-MIT-green.svg)](https://choosealicense.com/licenses/mit/)
