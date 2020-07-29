#  加密解密 相关

# 一、密钥格式：
    1、pem格式
-----BEGIN PRIVATE KEY-----
MIIEvQIBADANBgkqhkiG9w0BAQEFAASCBKcwggSjAgEAAoIBAQCLMEZhjinTZy9A+7d3jwsOCdsnYbEuJametlfBM9NzsoQKZW0PGB90o1BNnhJ7V9kGeQSPDpDgxM/eAwoPDTE8oARZEU/GD1vvxVdNVPUH+TXrLAWHhJ46w/z7OPIq7mxMy3bpFT6yiSCQyyAGfD1jTqbSnpvqsG1lI9uXGFhFRzjlqF6ulylEqmqmRarnaxJFyjPUlZGPdhJSIZP6u9YB8EI/8rLoEYcaRJhVvQhYMBbASdioqxEfwwYEWVgBzegksprP3YSGe6ITuJ9azxSINBvkgtzoNIVr5U8FEVFm4y2JBzwmlzDnFpdhu5nM6jIhsNjsP/7Hz8E4EXdnLvT3AgMBAAECggEAHR6hauGCMJ9CzJadAJ9lka9QMUIH/n6UqQa+/0WndGoho8cqdOD4G7/bGhH7DeEIH4mMAZ3rg4rJbko2fYWmCmfz4Op1RRuLgXNI233tsZhaxnO0SHDfZa4BLFHyoDa3Y62hmAwAzPtRW9mTPqgZc8BNuHzEY+o7SNCirU7DkOKQmqZLky9lhNFwW8dKYrgKeCGgiciae11K1V8vSPJKts4ljHPPBpeQOp1AaDCOj1Z6kjVoct9YEturtUmKNl/ilI/z+lfXZf+BXDbchEPRpdnpziZk1K7ZIRnC3q+C7sn3vrEqEfreFIiJ44hp6DqFKbhqxUmkd65s/1op8/sayQKBgQDe2A2VJt/WBGfuMQMbtPs2wWhKIT2o8I67LHSSv0JaqcVQrwMjzD0/tzXERBD6s1xIKFDGUKCfFwaDCm+UydWxPWROh+RiQLZZR7y/ct2VHfWe4FsuCzMKhEaOVhyxPdUen/eN42Cw0ClAN7dMgkFMKZlFr4uAxPY/IYdeAaxKowKBgQCf5dsMkblwyOVZ6ZGvQVQb0TsoY/0IAevDBEEOAD0pZRwEzg70d4MeZoWTkhfFk0HRriLO3HXcjJjDtbi0Q7/PTsV3POeRtHR4Dwceo4HiHefvc1G7F2pEGx3/PfgpXnTLqc4csxw107MPWoTOoiBGNt9PUSkxAVuiIcH+sbAFnQKBgCcggkoE+FpIjcMJwgT0YwN7NAeIDJ6EFluQ86rsgAcRNf7zq7Z2Xu64CW27kcujAHn+8ifP8lPcpB0QEQVr5uRm5hzPyW7i8+F7Mg3faj6LcxwBQqE0ADNBhG3resA4HhpxdfLo0IpbElMfNUTuve5Ug3/z0ae7bY0qIu2Dl6/HAoGANFB95JTg+TehYlN66L4VCKziEAr2xGHsgvenWS9W025TRncsiWt4qL+eQHPx9yCAzluM4+VZYnlVmeKgtcncvbTmAmcY1KEX4hf4mlugqRxjwAIY4X99sx60J8hcoxxWVjQOTXGEb0/+K63P+dMtgAt/8HF7ap8pHdixoeT81DkCgYEAk7iUqeZChXonALtgFPEYPV87r/vb9fMgo/NTe+7nL4xXxmPo4Ax+1+Yx109JRzibfqQoXyGbYOeWco6pnhTC7uucYUNrFmc5q0e7WL8Sl7f9QW1URROzRfawTgTIDmtfz4TtDR65X9uZ3hE9qaJArwtYw24ZvtNdbulmMB6iRrE=
-----END PRIVATE KEY-----
        
        
        
-----BEGIN PUBLIC KEY-----
MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAizBGYY4p02cvQPu3d48LDgnbJ2GxLiWpnrZXwTPTc7KECmVtDxgfdKNQTZ4Se1fZBnkEjw6Q4MTP3gMKDw0xPKAEWRFPxg9b78VXTVT1B/k16ywFh4SeOsP8+zjyKu5sTMt26RU+sokgkMsgBnw9Y06m0p6b6rBtZSPblxhYRUc45aherpcpRKpqpkWq52sSRcoz1JWRj3YSUiGT+rvWAfBCP/Ky6BGHGkSYVb0IWDAWwEnYqKsRH8MGBFlYAc3oJLKaz92EhnuiE7ifWs8UiDQb5ILc6DSFa+VPBRFRZuMtiQc8Jpcw5xaXYbuZzOoyIbDY7D/+x8/BOBF3Zy709wIDAQAB
-----END PUBLIC KEY-----
        
        报文：
{"appid":"SQYYPTHD","format":"json","biztype":"00020","sign":"JrKbYHQCEgRYD/CE5gGmxa0F83XzV1XGgad74Q+aEjbEEbVgPXN17YQOUHD9I/gQ3UxWvBL57rCS3t3T+/21352aceqBiTnxQAcx80EuUAQVD7KxH9tl3OTiSKMumPJcZTig1+4U97BCGalvOk6Ru+hM63kjqYK0Y98fhR1GzmVPDZtOMtFA3lEUt3ArzvtlXM6g8ziVf/nETFRWNfbiWZpVtyDSoEXhLlW7DMRjJM0x+KwUMMeiqcgG3kg+QGMt61x6Ir72DRURp+d2saACMG/NvmKpoq7OUkMLH2u8sA+QtSCeTBrZZ+HRJIWrU/TopV7h2iGwSOOu03XyxkbeZQ==","timestamp":"2020-07-08 17:54:48","version":"1.0","body":"VxypgJMgi3xFJsYpN33XqXjCSrcG5Lr10j4zSNO0vukt+z+6NyWYcx8X6eWviWCv","transactionid":"7e21d2fb5ce148ec9b4ab5ee49208788"}

    2、xml格式（c#默认）
        私钥：
        <RSAKeyValue><Modulus>riLSQFVDC229P5F+Mkicbkpg5OC8+SeL6hvkJXIGYiN/e4YnprCxuIp5sH9AwWup4WJmObPKd1jOVGm07UwgVU7CDtTaVe1Uuk78yJBwgRuSteQjHYMmH6nG5YHvvONuvkmLnyIKGygJBL+4+Qmd3GaCHRtIrdfShlH3UbPINlM=</Modulus><Exponent>AQAB</Exponent><P>6yCboYtKzIezMOFzGzzW8dp7SBT8f7jTRzH1ZIKQYKF0Mq/39k80SeUvY578O031+bg6i3cbNvvAhL8XjqTtmQ==</P><Q>vZgnL5LHnNE5uUW5NBwYvZbIz6hWNzc6kyDGimI8WBBFJOI06IdYGL2VMeGVs4lt5a1tM7T3c6gzBKgDQpL+yw==</Q><DP>p5tV9YDyr/unq5d6Uxc6bar9qHN1TqJ00VJ2h9BelNNinmM70fPB5U8fSddiG/BGAF3oNdSQrNAm+zmw1DkTOQ==</DP><DQ>fxS1b1XbJmm3X1A0y5DppGqlP0t+PpRuVp/pdGhUOlLthcN540KU8kBg+IZUaXr8hq6wO7BZDNT5HW3ggYc18Q==</DQ><InverseQ>q29etXnlszOH0FlQWDL9yLfJ+EruH4VURY1mZGz/+/qvPewUwyEf+EqJkZHVXEijnSa1CiFELK2YE9PhkUp2Xw==</InverseQ><D>bZUoLqf5KwYCJDDQ85/SIW3ZD++FvF1wpQCsUAwzjCq+nONNrI5hKLqr3bAW9iFkpJshrYpBDV3rah+jZfmUFk/UZeur2+kA2r5r1or34+HiIhT4sehU1lxww4DvTzf1/1ivG4LCvUPoFtT67Zdh8pNEC27N6bFDL8fbSU7GcmE=</D></RSAKeyValue>
        
        公钥：
        <RSAKeyValue><Modulus>riLSQFVDC229P5F+Mkicbkpg5OC8+SeL6hvkJXIGYiN/e4YnprCxuIp5sH9AwWup4WJmObPKd1jOVGm07UwgVU7CDtTaVe1Uuk78yJBwgRuSteQjHYMmH6nG5YHvvONuvkmLnyIKGygJBL+4+Qmd3GaCHRtIrdfShlH3UbPINlM=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>
        
        
     3、ASN格式（java）
        公钥：
        MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQDoUK4y6LX1kiHu0ubO1C1wRBrcgdSXBwI4CRuKK1fpTsS2dHpB5V+wQ63Rts3Ohr0E+pqIlaFu77Kp/UTczTH5dzSi4vdsexCBSnqC9RZLftadskTlf7OlHrF9Emva3s7Yla73EY56Jb0E/CS/PjKuNDNZ2CoZc2c3YBHDtObvhQIDAQAB   
        
       私钥： 
        MIICdQIBADANBgkqhkiG9w0BAQEFAASCAl8wggJbAgEAAoGBAOhQrjLotfWSIe7S5s7ULXBEGtyB1JcHAjgJG4orV+lOxLZ0ekHlX7BDrdG2zc6GvQT6moiVoW7vsqn9RNzNMfl3NKLi92x7EIFKeoL1Fkt+1p2yROV/s6UesX0Sa9reztiVrvcRjnolvQT8JL8+Mq40M1nYKhlzZzdgEcO05u+FAgMBAAECgYByqsAQ6MRHfeW51+eM1zXGYBdSF9My6Iaz2er5/ALcacC2vi9KL0lX21AEX1KeSesqdfeoyxJvi2iIdzZyNeYf52JUvvhnwedDu7YKi6xFgjvBbCPmifbau/r3JELQDHqRbnpYIe1NLrz9D0QBST5skGrYmeQe9NvVKEMMFuwPAQJBAPnTQI4AArADapYQjQnIE2Z94f1sAFkmvuI0kHikXFJKZ+CSWLw+vYrRkV1ct+Am2nz244e1AIcVG/iteYMs13UCQQDuDqKNFT43crjquJt3EzQWLxvQaK+bIKGVjcWje2xSH5oCiyPCk2RhWjd46aSPViPwyn5RPjsy0+EwLrm7xsXRAkAVbVYLF9sjJ5fbuR2vqhZn4wIgD0RUYStcEXAWuNomQLV6IHM16hetsV3LaSloM0zoDPDk8dRSwa+9e3uBkbYFAkAFOw0XTIAxd7PYdHX2B9X9JsvVqHczUWQ7hQHytaOLqmYX6DbA77wk53aQkZGsFJh1kf10i4mBdGZeSKiMF7IBAkAhniFbHF4G0RKxCJ3paII0m7qn3eI+pIPEGFX3sZjMYaYtWV9WmbvxytSdv88pa1Mh/ZxZjZTjsp0cq+XffD3r
        
        
        
        
# 报错：无法将类型为“System.Windows.Forms.SplitContainer”的对象强制转换为类型“System.ComponentModel.ISupportInitialize”。
    问题：将winform程序从.net framework 4.0 切换到.net 3.5时，运行时出现如下错误：
    无法将类型为“System.Windows.Forms.SplitContainer”的对象强制转换为类型“System.ComponentModel.ISupportInitialize”。    
    
    
    解决方法：
    注释掉如下两行代码（此代码为设计器自动生成代码）
    //((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
    //((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        