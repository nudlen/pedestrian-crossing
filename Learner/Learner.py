import pandas as pd
import numpy as np
import matplotlib.pyplot as plt
from keras.models import Sequential
from keras.layers import Dense
from keras.layers import GRU
import keras.backend as bkd
from keras.callbacks import LearningRateScheduler
from sklearn.metrics import mean_squared_error
from sklearn.preprocessing import MinMaxScaler
import warnings

warnings.filterwarnings('ignore')

df = pd.read_excel('shuju.xlsx')
print(df.head())

plt.rcParams['font.sans-serif'] = ['SimHei']      
plt.style.use('ggplot')                            

batch_size = 16          

dataset = df.iloc[:, 1:29].values                      
dataset = dataset.astype('float32')                   
scaler = MinMaxScaler()
dataset = scaler.fit_transform(dataset)                

dataout = df.iloc[:, 29].values         
dataout = dataout.astype('float32')     # 转化数据格式
me = dataout.mean()                          # 获取输出数据最小值
st = dataout.std()                           # 获取输出数据最大值
dataout = (dataout - me) /st               # 输出数据单位化

def create_dataset(dataset, dataout):    # 定义数据转化函数
    dataX, dataY = [], []
    for i in range(len(dataset)):
        a = dataset[i, :]
        dataX.append(a)
        b = dataout[i, ]
        b = np.reshape(b, (-1))
        dataY.append(b)
    return np.array(dataX), np.array(dataY)

X, Y = create_dataset(dataset, dataout)    
X = np.reshape(X, (X.shape[0], 1, 8))    
Y = np.reshape(Y, (Y.shape[0], 1))               # 转化训练数据维度
print(X.shape,Y.shape)

trainX = X[:1200]       # 拆分训练集测试集
trainY = Y[:1200]
testX = X[1200:]
testY = Y[1200:]

model = Sequential()          # 设定模型
    model.add(GRU(1,batch_input_shape=(batch_size, 1, 8),stateful=True))        # 设定GRU层
model.add(Dense(units=24))      # 添加中间层
model.add(Dense(units=48))      # 添加中间层
model.add(Dense(units=1))      # 添加输出层
model.compile(loss='mean_squared_error',optimizer='adam')

def scheduler(epoch):
    # 每隔40个epoch，学习率减小为原来的1/10
    if epoch % 50 == 0 and epoch != 0:
        lr = bkd.get_value(model.optimizer.lr)
        bkd.set_value(model.optimizer.lr, lr * 0.5)
        print("lr changed to {}".format(lr * 0.5))
    return bkd.get_value(model.optimizer.lr)
reduce_lr = LearningRateScheduler(scheduler)

model.fit(trainX, trainY, batch_size=batch_size, epochs=50, shuffle=False, verbose=2, callbacks=[reduce_lr])    # 训练数据

predict_train = model.predict(trainX, batch_size=batch_size)     # 计算训练集预测值
predict_train = predict_train * st + me               # 预测值还原
predict_test = model.predict(testX, batch_size=batch_size)       # 计算测试集预测值
predict_test = predict_test * st + me                 # 预测值还原
trainY = trainY * st + me         # 实际值还原
testY = testY * st + me          # 实际值还原

print('训练集轨迹：')
for i in predict_train:
    print(i[0])
print('\n')
print('测试集轨迹：')
for i in predict_test:
    print(i[0])


