FROM openjdk:15-jdk
COPY target/oreilly-camunda-instance.jar app.jar
EXPOSE 8080
ENTRYPOINT ["java","-Djava.security.egd=file:/dev/./urandom","-jar","/app.jar"]