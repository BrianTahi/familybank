﻿# familybank
# Family Bank & XYZ University Integration System

## Overview

This project implements a system to enable Family Bank to securely communicate tuition payment information to XYZ University in real-time. It includes two main RESTful APIs: one for student validation and another for payment notifications.

## Table of Contents

- [Technologies Used](#technologies-used)
- [Features](#features)
- [Installation](#installation)
- [Usage](#usage)
- [API Endpoints](#api-endpoints)
  - [Student Validation Endpoint](#student-validation-endpoint)
  - [Payment Notification Endpoint](#payment-notification-endpoint)
- [Data Structures](#data-structures)
- [Contributing](#contributing)
- [License](#license)

## Technologies Used

- **.NET Core 6.0**: Framework for building the APIs.
- **Entity Framework Core**: ORM for database interactions.
- **SQL Server**: Database management system used for storing student and payment information.
- **Swagger**: API documentation and testing tool.

## Features

- **Real-time payment notifications**: The system allows XYZ University to receive payment notifications immediately after a transaction.
- **Student validation**: The API can verify a student's enrollment status based on information provided by Family Bank.
- **Secure communication**: All data is transmitted securely to protect sensitive information.

## Installation

To set up this project locally, follow these steps:

1. **Clone the repository**:
   ```bash
   git clone https://github.com/BrianTahi/familybank.git
