SET IDENTITY_INSERT [dbo].[TVChannel] ON
INSERT INTO [dbo].[TVChannel] ([Id], [ChannelName], [Established]) VALUES (1, N'ABC Broadcasting', N'2019-11-20 00:00:00')
INSERT INTO [dbo].[TVChannel] ([Id], [ChannelName], [Established]) VALUES (2, N'Tech TV', N'2020-01-05 00:00:00')
SET IDENTITY_INSERT [dbo].[TVChannel] OFF
SET IDENTITY_INSERT [dbo].[TVShow] ON
INSERT INTO [dbo].[TVShow] ([Id], [TVChannelId], [ShowName]) VALUES (1, 2, N'Digital World')
INSERT INTO [dbo].[TVShow] ([Id], [TVChannelId], [ShowName]) VALUES (2, 1, N'Big Bang Theory')
SET IDENTITY_INSERT [dbo].[TVShow] OFF
SET IDENTITY_INSERT [dbo].[Subscriber] ON
INSERT INTO [dbo].[Subscriber] ([Id], [SubscriberName], [Email]) VALUES (1, N'Frank Houston', N'frank@gmail.com')
INSERT INTO [dbo].[Subscriber] ([Id], [SubscriberName], [Email]) VALUES (2, N'Stuart Wilson ', N'stuart@gmail.com')
SET IDENTITY_INSERT [dbo].[Subscriber] OFF
SET IDENTITY_INSERT [dbo].[Rating] ON
INSERT INTO [dbo].[Rating] ([Id], [SubscriberId], [TVShowId], [RatingValue]) VALUES (1, 1, 2, 4)
INSERT INTO [dbo].[Rating] ([Id], [SubscriberId], [TVShowId], [RatingValue]) VALUES (2, 1, 1, 5)
INSERT INTO [dbo].[Rating] ([Id], [SubscriberId], [TVShowId], [RatingValue]) VALUES (3, 2, 2, 5)
INSERT INTO [dbo].[Rating] ([Id], [SubscriberId], [TVShowId], [RatingValue]) VALUES (4, 2, 1, 3)
SET IDENTITY_INSERT [dbo].[Rating] OFF
