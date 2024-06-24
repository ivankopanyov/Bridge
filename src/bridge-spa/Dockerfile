FROM node:21 AS build
WORKDIR /app
COPY src/bridge-spa/. .
RUN npm install --maxsockets 1
RUN npm run build

FROM nginx:latest
COPY --from=build /app/build /usr/share/nginx/html
