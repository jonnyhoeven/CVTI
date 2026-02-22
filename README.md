# CVTI: Integrated Facility Automation & IoT Orchestration Platform

## Overview

A scalable, on-premise control architecture designed to unify disparate facility management systems into a single,
high-availability touch interface. This project demonstrates the implementation of an **Edge Controller** pattern,
orchestrating IP-based surveillance hardware, DMX lighting protocols, and infrastructure power management within a
secure, kiosk-mode environment.

![Windows Screenshot](http://jonnyhoeven.github.io/images/cvti.jpg)

## Business Value

* **Operational Efficiency**: Reduces Mean Time To Recovery (MTTR) for stage setup by centralizing control of lighting
  and visual monitoring systems.
* **High Availability**: Ensures continuous operation through automated error handling, network self-healing mechanisms,
  and watchdog timers for resource cleanup.
* **Security Compliance**: Implements **Zero Trust** principles at the application layer with PIN-based authentication,
  session timeouts, and restricted OS access.

## Architectural Highlights

### IoT Device Orchestration

* **RESTful Device Control**: Implements a robust client architecture to manage PTZ (Pan-Tilt-Zoom) IP cameras,
  abstracting vendor-specific APIs into a unified control interface.
* **Real-Time State Management**: Features precise control for focus, zoom, and preset recall, ensuring consistent
  visual monitoring standards.

### Resilient Infrastructure Integration

* **Self-Healing Network Connections**: Custom implementation of network resource mounting with exponential backoff and
  retry logic to handle transient network partitions, ensuring reliable access to backend storage.
* **Process Lifecycle Management**: Orchestrates external lighting control software with automated startup, shutdown,
  and configuration injection, ensuring consistent application state across reboots.

### Security & Governance

* **Kiosk Mode Implementation**: Locks down the host operating system to prevent unauthorized access, utilizing
  low-level hooks to manage window states and input focus.
* **Access Control**: Requires authentication for critical infrastructure operations (e.g., server reboots,
  configuration changes), preventing accidental or malicious disruptions during live production.

## Technical Stack

* **Platform**: .NET Framework (Windows Forms) for deep OS integration and hardware access.
* **Protocols**: HTTP/REST (Camera Control), SMB/CIFS (Network Storage), DMX512 (via Abstraction Layer).
* **Pattern**: Event-Driven UI with dedicated error handling layers.

---
*This project serves as a foundational reference for building robust, industrial-grade control interfaces where
reliability and direct hardware integration are paramount.*
