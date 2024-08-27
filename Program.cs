using PruebaRedis;

RedisHandler redisHandler = new RedisHandler();

redisHandler.Set("Prueba 2", "Esto es una prueba");

string result = redisHandler.Get("Prueba 2");

Console.WriteLine(result);