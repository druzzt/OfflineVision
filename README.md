
# react-native-offline-vision

## Getting started

`$ npm install react-native-offline-vision --save`

### Mostly automatic installation

`$ react-native link react-native-offline-vision`

### Manual installation


#### iOS

1. In XCode, in the project navigator, right click `Libraries` ➜ `Add Files to [your project's name]`
2. Go to `node_modules` ➜ `react-native-offline-vision` and add `RNOfflineVision.xcodeproj`
3. In XCode, in the project navigator, select your project. Add `libRNOfflineVision.a` to your project's `Build Phases` ➜ `Link Binary With Libraries`
4. Run your project (`Cmd+R`)<

#### Android

1. Open up `android/app/src/main/java/[...]/MainApplication.java`
  - Add `import com.reactlibrary.RNOfflineVisionPackage;` to the imports at the top of the file
  - Add `new RNOfflineVisionPackage()` to the list returned by the `getPackages()` method
2. Append the following lines to `android/settings.gradle`:
  	```
  	include ':react-native-offline-vision'
  	project(':react-native-offline-vision').projectDir = new File(rootProject.projectDir, 	'../node_modules/react-native-offline-vision/android')
  	```
3. Insert the following lines inside the dependencies block in `android/app/build.gradle`:
  	```
      compile project(':react-native-offline-vision')
  	```

#### Windows
[Read it! :D](https://github.com/ReactWindows/react-native)

1. In Visual Studio add the `RNOfflineVision.sln` in `node_modules/react-native-offline-vision/windows/RNOfflineVision.sln` folder to their solution, reference from their app.
2. Open up your `MainPage.cs` app
  - Add `using Offline.Vision.RNOfflineVision;` to the usings at the top of the file
  - Add `new RNOfflineVisionPackage()` to the `List<IReactPackage>` returned by the `Packages` method


## Usage
```javascript
import RNOfflineVision from 'react-native-offline-vision';

// TODO: What to do with the module?
RNOfflineVision;
```
  