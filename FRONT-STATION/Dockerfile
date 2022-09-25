FROM node:16.13.0-alpine3.14 As build
COPY . /app
WORKDIR /app

RUN npm install
RUN npm run build

FROM nginx:1.17.10-alpine

COPY --from=build /app/dist/myra /usr/share/nginx/html

