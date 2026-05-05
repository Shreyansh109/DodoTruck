Here’s a **clean, minimal, and focused version** of your README with only essential information:

---

# DodoTruck

A top-down 2D endless delivery game built with Unity 6.3 LTS.

---

## Overview

**DodoTruck** is an endless delivery game where players drive a truck to pick up and deliver orders across a multi-zone world.

* No win condition continuous gameplay loop
* Orders spawn randomly across the map
* Focus on exploration, navigation, and speed management

---

##  Core Gameplay

**Loop:**
`Explore → Find Order → Pickup → Deliver → Repeat`

### Key Mechanics

* **Boost Pads:** Increase speed when on road (`OnTriggerEnter2D`)
* **Collisions:** Reset speed on impact (`OnCollisionEnter2D`)
* **Random Orders:** Spawn at unknown locations
* **Low Visibility Zones:** Limited lighting using 2D lights
* **World Zones:** Forest, village, dark areas connected by roads

---

##  Tech Stack

* **Engine:** Unity 6.3 LTS (`6000.3.13f1`)
* **Language:** C#
* **Physics:** Rigidbody2D, Collider2D
* **Lighting:** Sprite Light 2D
* **Platforms:** Windows, macOS, Linux

---

##  Getting Started

### Requirements

* Unity Hub
* Unity 6.3 LTS
* Git

### Setup

```bash
git clone https://github.com/YOUR_USERNAME/DodoTruck.git
cd DodoTruck
```

Open in Unity Hub → Load project → Open:

```
Assets/Scenes/SampleScene.unity
```

Press ▶ Play to run.

---

## 🗂️ Project Structure

```
Assets/
├── Scenes/        # Main scene
├── Scripts/       # Game logic (Truck, Orders, World, UI)
├── Prefabs/       # Reusable objects
├── Sprites/       # Art assets
├── Tilemaps/      # Zone tiles
└── Lighting/      # Light settings
```

---

##  Features

* Endless gameplay loop
* Random order spawning
* Speed boost system
* Collision penalty system
* Zone-based world design
* 2D lighting & visibility zones
