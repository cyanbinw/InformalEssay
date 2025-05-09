﻿// See https://aka.ms/new-console-template for more information

using TestCode;
using TestCode.TestAbstract;
using TestCode.TestCopy;
using TestCode.TestDelegation;
using TestCode.TestDependencyInjection;
using TestCode.TestList;
using TestCode.TestLock;
using TestCode.TestMongodb;
using TestCode.TestNewFunction;
using TestCode.TestProperty;
using TestCode.TestReadOnly;
using TestCode.TestRedis;
using TestCode.TestThreaded;
using TestCode.TestTreeNode;

var factory = new TestFactory();
ITest test = factory.Factory[TestType.BaseTest]();

Console.WriteLine("------------------Test Complete---------------");
Console.ReadKey();

//BaseTest data = new DataWork();
//data.Action();

//BaseTest dataAbstract = new DataWork();
//dataAbstract.Action();

//BaseTest copy = new Copy();
//copy.Action();

//BaseTest list = new WorkList();
//list.Action();

//BaseTest dependency = new DependencyInjection();
//dependency.Action();

//BaseTest run = new RunTest();
//run.Action();

//BaseTest threaded = new Threaded();
//threaded.Action();

//BaseTest delegates = new DelegateWork();
//delegates.Action();

//BaseTest property = new PropertyWork();
//property.Action();

//BaseTest mongo = new MongoWork();
//mongo.Action();

//BaseTest redis = new RedisWork();
//redis.Action();

//BaseTest treeNode = new TreeNodeWork();
//treeNode.Action();

BaseTest lockData = new WorkLock();
lockData.Action();
//BaseTest redis = new RedisWork();
//redis.Action();

BaseTest readOnly = new ReadOnlyWork();
readOnly.Action();





