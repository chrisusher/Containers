pipeline {
  agent {
    node {
      label 'master'
    }

  }
  stages {
    stage('Copy Artifacts') {
      steps {
        copyArtifacts 'Build'
      }
    }
  }
}