/* groovylint-disable-next-line CompileStatic */
pipeline {
    options {
        skipDefaultCheckout(true)
    }

    agent any

    parameters {
        string(name: 'BRANCH', defaultValue: '*/main', description: 'Escolhe a branch')
    }
    stages {
        // stage ('Checkout branch') {
        //     steps {
        //         /* groovylint-disable-next-line LineLength */
        //         checkout([$class: 'GitSCM',
        //         branches: [[name: "${params.BRANCH}"]],
        //          doGenerateSubmoduleConfigurations: false,
        //           extensions: [],
        //           subModuleCfg: [],
        //           useRemoteConfigs: [[url: 'https://github.com/Hrsrocha/JenkinsTests.git']]
        //           ])
        //     }
        // }

        stage ('build') {
            steps {
                echo 'building'
                sh '''
                    rm -rf JenkinsTests
                    git clone https://github.com/Hrsrocha/JenkinsTests.git
                    cd JenkinsTests/JenkinsTests
                    dotnet restore
                    dotnet build
                '''
            }
        }
        stage ('MS Test') {
            steps {
                sh '''
                    pwd
                    ls
                    cd JenkinsTests/JenkinsTests/tests/JenkinsTests.MSTestFake
                    dotnet test JenkinsTests.MSTestFake.csproj --no-build --no-restore
                '''
            }
        }
        stage ('nUnit') {
            steps {
                sh '''
                    pwd
                    ls
                    cd JenkinsTests/JenkinsTests/tests/JenkinsTests.nUnitFake
                    dotnet test JenkinsTests.nUnitFake.csproj --no-build --no-restore
                '''
            }
        }
        stage ('xUnit') {
            steps {
                sh '''
                    pwd
                    ls
                    cd JenkinsTests/JenkinsTests/tests/JenkinsTests.xUnitFake
                    dotnet test JenkinsTests.xUnitFake.csproj --no-build --no-restore
                '''
            }
        }
        stage ('Clear') {
            steps {
                sh '''
                    rm -rf JenkinsTests
                '''
                echo 'Cleaning'
            }
        }
    }
}
