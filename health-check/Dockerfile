# We use the alpine as base image
FROM mcr.microsoft.com/dotnet/aspnet:5.0-alpine-amd64

# Perform the health check call via curl
HEALTHCHECK --interval=5s --timeout=3s CMD curl --fail http://localhost/healthcheck || exit 1

RUN apk --update --no-cache add curl

# Create a group and usermcr.microsoft.com/dotnet/runtime
RUN addgroup --gid 1000 -S app && adduser --uid 1000 -S app -G app

# Create the work dir and set permissions as WORKDIR set the permissions as root
RUN mkdir /home/app/net && chown -R app:app /home/app/net
WORKDIR /home/app/net

# Switch to the created user
USER app

# Copy the binaries to the apps directory
COPY --chown=app:app bin/Release/net5.0/publish/* /home/app/net/

# Start the application
CMD ["dotnet", "health-check.dll"]
