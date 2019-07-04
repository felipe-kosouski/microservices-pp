FROM openjdk:8u171-jre-alpine
WORKDIR /eureka-server
COPY --from=build /scratch .
EXPOSE 8761
ENTRYPOINT ["java", "-Djava.security.egd=file:/dev/./urandom", "-jar", "eureka-server.jar"]