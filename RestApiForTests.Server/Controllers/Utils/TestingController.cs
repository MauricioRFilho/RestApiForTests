GET /api/utils/timezones

GET /api/utils/fake-data – retorna JSON fake de exemplo

POST /api/utils/echo – retorna o body enviado (ótimo pra testes)

GET /api/utils/headers – retorna headers recebidos (debug)

GET /api/utils/latency?ms=2000 – simula latência

GET /api/utils/error?code=500 – simula erro de status

GET  /api/test/latency?ms=2000   // Simula atraso
GET  /api/test/error?code=500    // Simula erro HTTP
POST /api/test/echo              // Retorna o que foi enviado
GET  /api/test/headers           // Retorna headers da requisição
