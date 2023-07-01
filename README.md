<!DOCTYPE html>
<html>

<head>
  <title>Ads_by_using_Face_detection</title>
</head>

<body>

  <h1>Ads_by_using_Face_detection</h1>

  <p>This project contains a Winforms application for desktop and a Python script for playing ads and detecting age and gender.</p>

  <h2>Additional Python Libraries Required:</h2>
  <ul>
    <li>OpenCV</li>
    <pre><code>pip install opencv-python</code></pre>
    <li>argparse</li>
    <pre><code>pip install argparse</code></pre>
  </ul>

  <h2>Contents of the main/Script file:</h2>
  <ul>
    <li>opencv_face_detector.pbtxt</li>
    <li>opencv_face_detector_uint8.pb</li>
    <li>age_deploy.prototxt</li>
    <li>age_net.caffemodel</li>
    <li>gender_deploy.prototxt</li>
    <li>gender_net.caffemodel</li>
  </ul>
  <p>For face detection, we have a .pb file - this is a protobuf file (protocol buffer); it holds the graph definition
    and the trained weights of the model. We can use this to run the trained model. And while a .pb file holds the
    protobuf in binary format, one with the .pbtxt extension holds it in text format. These are TensorFlow files. For
    age and gender, the .prototxt files describe the network configuration and the .caffemodel file defines the internal
    states of the parameters of the layers.</p>

  <h2>Usage:</h2>
  <p><b>Downloading Repository:</b></p>
  <ul>
    <li>Download the repository or the Setup.exe from the following link:
      <a href="https://drive.google.com/file/d/1WjhLqJZyNEuX_U8yyvdtAx0gSHOW--n3/view?usp=sharing">link</a>
    </li>
  </ul>
  <p><b>By Downloading Repository:</b></p>
  <ul>
    <li>Change the directory to the folder where all the files are present.</li>
    <li>Go to <b>Ads_system/bin/Debug/net6.0-windows/</b>.</li>
    <li>Run <b>Ads_system.exe</b>.</li>
  </ul>
  </ul>
  <p><b>By Downloading Setup:</b></p>
  <ul>
    <li>Open <b>Ads_system.exe</b>.</li>
    <li>Setup password: <b>12345678</b>.</li>
    <li>Install the setup only at <b>D:</b> drive (otherwise, it won't work).</li>
    <li>After installation, a shortcut will appear on the desktop.</li>
  </ul>

  <h2>Features:</h2>
  <ul>
    <li>The interface contains three buttons.</li>
    <li>Male button: Opens a folder to manage ads for males.</li>
    <li>Female button: Opens a folder to manage ads for females.</li>
    <li>Run button: Runs the script.</li>
  </ul>

  <h2>For Script:</h2>
  <h1>Visit:</h1>
  <p>[website link]</p>
  <a href="https://ibb.co/QrvhPvL"><img src="https://i.ibb.co/72tBntP/Screenshot-2023-06-25-021013.png" alt="Screenshot-2023-06-25-021013" border="0"></a>

</body>


</html>


