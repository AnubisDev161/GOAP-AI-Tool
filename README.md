
## 🛠️ GOAP-AI-Tool by AnubisDev161  

This tool is a node based editor tool for the creation of AI behavior using the GOAP AI Pattern and is a free and open source package for the Unity Engine.

### Features
- Node Based Editor
- GOAP Runtime Planner
- Blackboard
- GOAP Agent
- Focus on Extendability
  
## 📜 HowTo Document

This [HowTo document](https://github.com/AnubisDev161/GOAP-AI-Tool/blob/main/Documentation/GOAP%20AI%20Tool%20-%20How%20To%20Document.pdf) covers the basics of the tool.

## 🔖 Example Project
<img width="1917" height="862" alt="image" src="https://github.com/user-attachments/assets/41be8129-c4df-4d76-86eb-80ade8661bc3" />

You can find a practical example implementation of the tool in my [example project](https://github.com/AnubisDev161/GOAP-AI-Tool-Sample-Project).


## ✨ Features  
### 🎛️ Node Based Editor
<img width="1913" height="857" alt="GOAP Graph" src="https://github.com/user-attachments/assets/ed7f0f7b-20d0-456c-84fd-9309cc1e9892" />

The [NodeEditor](https://github.com/AnubisDev161/GOAP-AI-Tool/blob/main/Editor/GOAPGraph/GOAPGraphEditorWindow.cs) is the graphical interface that designers can use to create behavior. 
Similar to a behavior tree with the main difference that the execution order of tasks is evaulated at runtime by the [GOAPPlanner](https://github.com/AnubisDev161/GOAP-AI-Tool/blob/main/Runtime/GOAPCore/Agent/GOAPPlanner.cs).

###  🧾 GOAP Runtime Planner
<img width="1012" height="425" alt="image" src="https://github.com/user-attachments/assets/72899463-4ded-467e-826c-5c28a8bfc17c" />

The [GOAPPlanner](https://github.com/AnubisDev161/GOAP-AI-Tool/blob/main/Runtime/GOAPCore/Agent/GOAPPlanner.cs) handles the actual planning logic by using pathfinding

### 🧠 Blackboard
<img width="296" height="390" alt="Blackboard" src="https://github.com/user-attachments/assets/9aef84a1-8ad7-48b5-bb8c-204dcb8e81f2" />

The [Balckboard](https://github.com/AnubisDev161/GOAP-AI-Tool/blob/main/Runtime/GOAPCore/Agent/Brain/GOAPBlackbaord.cs) is used to store a variety of data, such as positions, GameObjects and other task relevant data.

### 🤖 GOAP Agent 
<img width="1086" height="372" alt="image" src="https://github.com/user-attachments/assets/befd8436-c4a5-466e-904d-6633b96b95f3" />

The [GOAPAgent](https://github.com/AnubisDev161/GOAP-AI-Tool/blob/main/Runtime/GOAPCore/Agent/GOAPAgent.cs) connects the GOAP planner with the game world and can be attached to any actor as a component.

### 🧩 Focus on Extendability
<img width="1242" height="718" alt="Extendability" src="https://github.com/user-attachments/assets/f73e8bb3-ec84-48b0-b2f1-bd9b4eb1db31" />

The [ActionNode](https://github.com/AnubisDev161/GOAP-AI-Tool/blob/main/Runtime/GOAPGraph/NodeTypes/ActionNode.cs) is the base class for any action node that can be used in the GOAPGraph. Designed to be used as the parent class for any custom action that the agent can perform. 
