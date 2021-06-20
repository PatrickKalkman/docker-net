# We use the alpine as base image
FROM mcr.microsoft.com/dotnet/runtime:5.0-alpine-amd64

# Create a group and user
RUN addgroup --gid 1000 -S app && adduser --uid 1000 -S app -G app

# Create the work dir and set permissions as WORKDIR set the permissions as root
RUN mkdir /home/app/net && chown -R app:app /home/app/net
WORKDIR /home/app/net

# Switch to the created user
USER app

# Copy the binaries to the apps directory
COPY --chown=app:app bin/Release/net5.0/publish/* /home/app/net/

# Start the application
CMD ["dotnet", "NetCore.NonRoot.dll"]
