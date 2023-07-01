

<h1>Ads using Face Detection</h1>
<img src="https://i.ibb.co/72tBntP/Screenshot-2023-06-25-021013.png" alt="Screenshot-2023-06-25-021013">
<p>This project involves a Winforms application for desktop and a Python script for playing ads and performing age and gender detection using face detection.</p>
<h2>Additional Python Libraries Required:</h2>
<ul>
  <li>OpenCV</li>
  <li>Install with: <code>pip install opencv-python</code></li>
  <li>argparse</li>
  <li>Install with: <code>pip install argparse</code></li>
</ul>
<h2>Contents of the Main/Script File:</h2>
<ul>
  <li>opencv_face_detector.pbtxt</li>
  <li>opencv_face_detector_uint8.pb</li>
  <li>age_deploy.prototxt</li>
  <li>age_net.caffemodel</li>
  <li>gender_deploy.prototxt</li>
  <li>gender_net.caffemodel</li>
</ul>
<p>The <strong>.pb</strong> and <strong>.pbtxt</strong> files are protobuf files that define the graph and trained weights of the face detection model. The <strong>.prototxt</strong> files describe the network configuration, and the <strong>.caffemodel</strong> files define the internal states of the parameters for age and gender detection.</p>
<h2>Usage:</h2>
<p><strong>Downloading the Repository:</strong></p>
<ul>
  <li>Download the repository or the Setup.exe file from the following link: <a href="https://drive.google.com/file/d/1WjhLqJZyNEuX_U8yyvdtAx0gSHOW--n3/view?usp=sharing">link</a></li>
</ul>
<p><strong>Using the Downloaded Repository:</strong></p>
<ul>
  <li>Change the directory to the folder where all the files are located.</li>
  <li>Navigate to <strong>Ads_system/bin/Debug/net6.0-windows/</strong>.</li>
  <li>Run the <strong>Ads_system.exe</strong> file.</li>
</ul>
<p><strong>Using the Downloaded Setup:</strong></p>
<ul>
  <li>Open the <strong>Ads_system.exe</strong> file.</li>
  <li>Enter the setup password: <strong>12345678</strong>.</li>
  <li>Install the setup only at <strong>D:</strong> drive (otherwise, it won't work).</li>
  <li>After installation, a shortcut will appear on the desktop.</li>
</ul>
<h2>Features:</h2>
<ul>
  <li>The interface contains three buttons.</li>
  <li>👨 Male button: Opens a folder to manage ads for males.</li>
  <li>👩 Female button: Opens a folder to manage ads for females.</li>
  <li>▶️ Run button: Runs the script.</li>
</ul>
<h2>For Script:</h2>
<p>Visit: <a href="https://github.com/Abdullah-129/Real-Time-Age-and-Gender-Detection-with-Video-Ads">GitHub Repository</a></p>
<h2>🤝 Contributing</h2>
<p>Contributions to this project are welcome! If you find any issues or have suggestions for improvements, please open an issue or submit a pull request.</p>
<h2>📄 License</h2>
<p>This project is licensed under the <a href="LICENSE">MIT License</a>.</p>
<h2>🙏 Acknowledgments</h2>
<ul>
  <li>The age and gender prediction models are based on the work of <a href="https://talhassner.github.io/home/publication/2015_CVPR">Gil Levi and Tal Hassner</a>.</li>
  <li>The face detection model is based on the work of <a href="https://github.com/opencv/opencv">OpenCV</a>.</li>
</ul>
<h2>🔗 References</h2>
<ul>
  <li><a href="https://opencv.org">OpenCV</a></li>
  <li><a href="https://talhassner.github.io/home/publication/2015_CVPR">Age and Gender Classification Using Convolutional Neural Networks</a></li>
</ul>
