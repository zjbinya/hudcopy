   M S B A M L   `   `   `  ���� c  _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35qPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.InteractivitySystem.Windows.Interactivity  G CAIC.CoreType, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA0clr-namespace:AIC.CoreType;assembly=AIC.CoreTypeAIC.CoreType E AAIC.Themes, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM5clr-namespace:AIC.Themes.Controls;assembly=AIC.ThemesAIC.Themes.Controls C ?AIC.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5(clr-namespace:AIC.Core;assembly=AIC.CoreAIC.Core N JAIC.HistoryDataPage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:AIC.HistoryDataPage.ViewModelsAIC.HistoryDataPage.ViewModels E'clr-namespace:AIC.HistoryDataPage.ViewsAIC.HistoryDataPage.Views R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089    booleanToVisibilityConverter'   !AIC.Core.EnumDescriptionConverter  enumDescriptionConverter!  AIC.Core.IntToUnitConverter  intToUnitConverter  enumComboItemTemplate  �� Path �� 	Converter " VInfoContractComboItemTemplate � DataContext �� StringFormat  NoBorder �� 
TargetType �� Property �� Value  ReplayTemplate �� DataType;  5AIC.HistoryDataPage.ViewModels.RMSReplayDataViewModel.   (System.Windows.Interactivity.Interaction   	Behaviors%  AIC.Core.FluidMouseDragBehavior	   
DragButton # ChartBackgroundAccentColorBrush1  +AIC.HistoryDataPage.Views.RMSReplayDataView
 F�Name �� Stretch �� Triggers �� Value �� Binding �� 
TargetName  TimeDomainTemplate<  6AIC.HistoryDataPage.ViewModels.TimeDomainDataViewModel2  ,AIC.HistoryDataPage.Views.TimeDomainDataView 	 FrequencyDomainTemplateA  ;AIC.HistoryDataPage.ViewModels.FrequencyDomainDataViewModel7	  1AIC.HistoryDataPage.Views.FrequencyDomainDataView 
 PowerSpectrumTemplate?
  9AIC.HistoryDataPage.ViewModels.PowerSpectrumDataViewModel5  /AIC.HistoryDataPage.Views.PowerSpectrumDataView   PowerSpectrumDensityTemplateF  @AIC.HistoryDataPage.ViewModels.PowerSpectrumDensityDataViewModel<  6AIC.HistoryDataPage.Views.PowerSpectrumDensityDataView  OrthoTemplate7  1AIC.HistoryDataPage.ViewModels.OrthoDataViewModel-  'AIC.HistoryDataPage.Views.OrthoDataView  OffDesignConditionTemplateD  >AIC.HistoryDataPage.ViewModels.OffDesignConditionDataViewModel:  4AIC.HistoryDataPage.Views.OffDesignConditionDataView  OrderAnalysisTemplate?  9AIC.HistoryDataPage.ViewModels.OrderAnalysisDataViewModel5  /AIC.HistoryDataPage.Views.OrderAnalysisDataView  Time3DSpectrumTemplate@  :AIC.HistoryDataPage.ViewModels.Time3DSpectrumDataViewModel2  ,AIC.HistoryDataPage.Views.Time3DSpectrumView  RPM3DSpectrumTemplate?  9AIC.HistoryDataPage.ViewModels.RPM3DSpectrumDataViewModel5  /AIC.HistoryDataPage.Views.RPM3DSpectrumDataView  DistributionMapTemplate=  7AIC.HistoryDataPage.ViewModels.DistributionMapViewModel3  -AIC.HistoryDataPage.Views.DistributionMapView  AlarmPointTrendTemplateA  ;AIC.HistoryDataPage.ViewModels.AlarmPointTrendDataViewModel7  1AIC.HistoryDataPage.Views.AlarmPointTrendDataView�� D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     ViPclr-namespace:System.Windows.Interactivity;assembly=System.Windows.Interactivity  =coreType0clr-namespace:AIC.CoreType;assembly=AIC.CoreType  BControls5clr-namespace:AIC.Themes.Controls;assembly=AIC.Themes  1core(clr-namespace:AIC.Core;assembly=AIC.Core  :	viewModel,clr-namespace:AIC.HistoryDataPage.ViewModels  1views'clr-namespace:AIC.HistoryDataPage.Views  %�,  &	        &	      &	 
     &	      7  &	 2     &	 �     &	 �     &	 k    &		     7   &	
 �    &	 [    &	 �    &	 �    &	 /    &	 �    &	 g!    &	 %    &	 �(    ��      �� .R��� ���� $  .�8   �� .R���  �� ��`� $ 	{0}{1}{2}��.1��� $  DevSN��� $
  Name��� $
  MSSN��� " ��.���  � ��$ 0q���  � ��
 �   ��� "  .R�� ���� *	ItemWidth+���� *
ItemHeight+   $
	 Left=�.+�� $��3q�#���  .+�  F� $
 TopLeftPath��$��2��"����k"��pѰ��pѰ��H	$
��Left=�$	��Top=�$��15��$��15��$
 Fill=����	#FF87CDEE$��3��F� $
 TopRightPath��$��2��"�������kч	��kч	�e�	$��Right=�$	��Top=�$��15��$��15��$
 Fill=����	#FF87CDEE$��3��F� $
 BottomLeftPath��$��2��'���P�Ed7�@�@��E�� ����� 	$
��Left=�$��Bottom=�$��15��$��15��$
 Fill=����	#FF87CDEE$��3��F� $
 BottomRightPath��$��2��"����h�흤 �h���.р�7��.	$��Right=�$��Bottom=�$��15��$��15��$
 Fill=����	#FF87CDEE$��3�� �� $
 True�� �� *
IsSelected+.a��� $ TopLeftPath�� � ��
 � ����� $ TopRightPath�� � ��
 � ����� $ BottomLeftPath�� � ��
 � ����� $ BottomRightPath�� � ��
 � ����� "  .R�� ���� *	ItemWidth+���� *
ItemHeight+   $
	 Left=�.+�� $��3q�#���  .+�  F� $
 TopLeftPath��$��2��"����k"��pѰ��pѰ��H	$
��Left=�$	��Top=�$��15��$��15��$
 Fill=����	#FF87CDEE$��3��F� $
 TopRightPath��$��2��"�������kч	��kч	�e�	$��Right=�$	��Top=�$��15��$��15��$
 Fill=����	#FF87CDEE$��3��F� $
 BottomLeftPath��$��2��'���P�Ed7�@�@��E�� ����� 	$
��Left=�$��Bottom=�$��15��$��15��$
 Fill=����	#FF87CDEE$��3��F� $
 BottomRightPath��$��2��"����h�흤 �h���.р�7��.	$��Right=�$��Bottom=�$��15��$��15��$
 Fill=����	#FF87CDEE$��3�� �� $
 True�� �� *
IsSelected+.a��� $ TopLeftPath�� � ��
 � ����� $ TopRightPath�� � ��
 � ����� $ BottomLeftPath�� � ��
 � ����� $ BottomRightPath�� � ��
 � ����� "  .R�� ���� *	ItemWidth+���� *
ItemHeight+   $
	 Left=�.+�� $��3q�#���  .+�	  y��� *	IsVisible+8   F� $
 TopLeftPath��$��2��"����k"��pѰ��pѰ��H	$
��Left=�$	��Top=�$��15��$��15��$
 Fill=����	#FF87CDEE$��3��F� $
 TopRightPath��$��2��"�������kч	��kч	�e�	$��Right=�$	��Top=�$��15��$��15��$
 Fill=����	#FF87CDEE$��3��F� $
 BottomLeftPath��$��2��'���P�Ed7�@�@��E�� ����� 	$
��Left=�$��Bottom=�$��15��$��15��$
 Fill=����	#FF87CDEE$��3��F� $
 BottomRightPath��$��2��"����h�흤 �h���.р�7��.	$��Right=�$��Bottom=�$��15��$��15��$
 Fill=����	#FF87CDEE$��3�� �� $
 True�� �� *
IsSelected+.a��� $ TopLeftPath�� � ��
 � ����� $ TopRightPath�� � ��
 � ����� $ BottomLeftPath�� � ��
 � ����� $ BottomRightPath�� � ��
 � ����� " 
 .R�� ���� *	ItemWidth+���� *
ItemHeight+   $
	 Left=�.+�� $��3q�#���  .+�  F� $
 TopLeftPath��$��2��"����k"��pѰ��pѰ��H	$
��Left=�$	��Top=�$��15��$��15��$
 Fill=����	#FF87CDEE$��3��F� $
 TopRightPath��$��2��"�������kч	��kч	�e�	$��Right=�$	��Top=�$��15��$��15��$
 Fill=����	#FF87CDEE$��3��F� $
 BottomLeftPath��$��2��'���P�Ed7�@�@��E�� ����� 	$
��Left=�$��Bottom=�$��15��$��15��$
 Fill=����	#FF87CDEE$��3��F� $
 BottomRightPath��$��2��"����h�흤 �h���.р�7��.	$��Right=�$��Bottom=�$��15��$��15��$
 Fill=����	#FF87CDEE$��3�� �� $
 True�� �� *
IsSelected+.a��� $ TopLeftPath�� � ��
 � ����� $ TopRightPath�� � ��
 � ����� $ BottomLeftPath�� � ��
 � ����� $ BottomRightPath�� � ��
 � ����� "  .R�� ���� *	ItemWidth+���� *
ItemHeight+   $
	 Left=�.+�� $��3q�#���  .+�  F� $
 TopLeftPath��$��2��"����k"��pѰ��pѰ��H	$
��Left=�$	��Top=�$��15��$��15��$
 Fill=����	#FF87CDEE$��3��F� $
 TopRightPath��$��2��"�������kч	��kч	�e�	$��Right=�$	��Top=�$��15��$��15��$
 Fill=����	#FF87CDEE$��3��F� $
 BottomLeftPath��$��2��'���P�Ed7�@�@��E�� ����� 	$
��Left=�$��Bottom=�$��15��$��15��$
 Fill=����	#FF87CDEE$��3��F� $
 BottomRightPath��$��2��"����h�흤 �h���.р�7��.	$��Right=�$��Bottom=�$��15��$��15��$
 Fill=����	#FF87CDEE$��3�� �� $
 True�� �� *
IsSelected+.a��� $ TopLeftPath�� � ��
 � ����� $ TopRightPath�� � ��
 � ����� $ BottomLeftPath�� � ��
 � ����� $ BottomRightPath�� � ��
 � ����� "  .R�� ���� *	ItemWidth+���� *
ItemHeight+   $
	 Left=�.+�� $��3q�#���  .+�  F� $
 TopLeftPath��$��2��"����k"��pѰ��pѰ��H	$
��Left=�$	��Top=�$��15��$��15��$
 Fill=����	#FF87CDEE$��3��F� $
 TopRightPath��$��2��"�������kч	��kч	�e�	$��Right=�$	��Top=�$��15��$��15��$
 Fill=����	#FF87CDEE$��3��F� $
 BottomLeftPath��$��2��'���P�Ed7�@�@��E�� ����� 	$
��Left=�$��Bottom=�$��15��$��15��$
 Fill=����	#FF87CDEE$��3��F� $
 BottomRightPath��$��2��"����h�흤 �h���.р�7��.	$��Right=�$��Bottom=�$��15��$��15��$
 Fill=����	#FF87CDEE$��3�� �� $
 True�� �� *
IsSelected+.a��� $ TopLeftPath�� � ��
 � ����� $ TopRightPath�� � ��
 � ����� $ BottomLeftPath�� � ��
 � ����� $ BottomRightPath�� � ��
 � ����� "  .R�� ���� *	ItemWidth+���� *
ItemHeight+   $
	 Left=�.+�� $��3q�#���  .+�  F� $
 TopLeftPath��$��2��"����k"��pѰ��pѰ��H	$
��Left=�$	��Top=�$��15��$��15��$
 Fill=����	#FF87CDEE$��3��F� $
 TopRightPath��$��2��"�������kч	��kч	�e�	$��Right=�$	��Top=�$��15��$��15��$
 Fill=����	#FF87CDEE$��3��F� $
 BottomLeftPath��$��2��'���P�Ed7�@�@��E�� ����� 	$
��Left=�$��Bottom=�$��15��$��15��$
 Fill=����	#FF87CDEE$��3��F� $
 BottomRightPath��$��2��"����h�흤 �h���.р�7��.	$��Right=�$��Bottom=�$��15��$��15��$
 Fill=����	#FF87CDEE$��3�� �� $
 True�� �� *
IsSelected+.a��� $ TopLeftPath�� � ��
 � ����� $ TopRightPath�� � ��
 � ����� $ BottomLeftPath�� � ��
 � ����� $ BottomRightPath�� � ��
 � ����� "  .R�� ���� *	ItemWidth+���� *
ItemHeight+   $
	 Left=�.+�� $��3q�#���  .+�  F� $
 TopLeftPath��$��2��"����k"��pѰ��pѰ��H	$
��Left=�$	��Top=�$��15��$��15��$
 Fill=����	#FF87CDEE$��3��F� $
 TopRightPath��$��2��"�������kч	��kч	�e�	$��Right=�$	��Top=�$��15��$��15��$
 Fill=����	#FF87CDEE$��3��F� $
 BottomLeftPath��$��2��'���P�Ed7�@�@��E�� ����� 	$
��Left=�$��Bottom=�$��15��$��15��$
 Fill=����	#FF87CDEE$��3��F� $
 BottomRightPath��$��2��"����h�흤 �h���.р�7��.	$��Right=�$��Bottom=�$��15��$��15��$
 Fill=����	#FF87CDEE$��3�� �� $
 True�� �� *
IsSelected+.a��� $ TopLeftPath�� � ��
 � ����� $ TopRightPath�� � ��
 � ����� $ BottomLeftPath�� � ��
 � ����� $ BottomRightPath�� � ��
 � ����� "  .R�� ���� *	ItemWidth+���� *
ItemHeight+   $
	 Left=�.+�� $��3q�#���  .+�  F� $
 TopLeftPath��$��2��"����k"��pѰ��pѰ��H	$
��Left=�$	��Top=�$��15��$��15��$
 Fill=����	#FF87CDEE$��3��F� $
 TopRightPath��$��2��"�������kч	��kч	�e�	$��Right=�$	��Top=�$��15��$��15��$
 Fill=����	#FF87CDEE$��3��F� $
 BottomLeftPath��$��2��'���P�Ed7�@�@��E�� ����� 	$
��Left=�$��Bottom=�$��15��$��15��$
 Fill=����	#FF87CDEE$��3��F� $
 BottomRightPath��$��2��"����h�흤 �h���.р�7��.	$��Right=�$��Bottom=�$��15��$��15��$
 Fill=����	#FF87CDEE$��3�� �� $
 True�� �� *
IsSelected+.a��� $ TopLeftPath�� � ��
 � ����� $ TopRightPath�� � ��
 � ����� $ BottomLeftPath�� � ��
 � ����� $ BottomRightPath�� � ��
 � ����� "  .R�� ���� *	ItemWidth+���� *
ItemHeight+   $
	 Left=�.+�� $��3q�#���  .+�  F� $
 TopLeftPath��$��2��"����k"��pѰ��pѰ��H	$
��Left=�$	��Top=�$��15��$��15��$
 Fill=����	#FF87CDEE$��3��F� $
 TopRightPath��$��2��"�������kч	��kч	�e�	$��Right=�$	��Top=�$��15��$��15��$
 Fill=����	#FF87CDEE$��3��F� $
 BottomLeftPath��$��2��'���P�Ed7�@�@��E�� ����� 	$
��Left=�$��Bottom=�$��15��$��15��$
 Fill=����	#FF87CDEE$��3��F� $
 BottomRightPath��$��2��"����h�흤 �h���.р�7��.	$��Right=�$��Bottom=�$��15��$��15��$
 Fill=����	#FF87CDEE$��3�� �� $
 True�� �� *
IsSelected+.a��� $ TopLeftPath�� � ��
 � ����� $ TopRightPath�� � ��
 � ����� $ BottomLeftPath�� � ��
 � ����� $ BottomRightPath�� � ��
 � ����� "  .R�� ���� *	ItemWidth+���� *
ItemHeight+   $
	 Left=�.+�� $��3q�#���  .+�  F� $
 TopLeftPath��$��2��"����k"��pѰ��pѰ��H	$
��Left=�$	��Top=�$��15��$��15��$
 Fill=����	#FF87CDEE$��3��F� $
 TopRightPath��$��2��"�������kч	��kч	�e�	$��Right=�$	��Top=�$��15��$��15��$
 Fill=����	#FF87CDEE$��3��F� $
 BottomLeftPath��$��2��'���P�Ed7�@�@��E�� ����� 	$
��Left=�$��Bottom=�$��15��$��15��$
 Fill=����	#FF87CDEE$��3��F� $
 BottomRightPath��$��2��"����h�흤 �h���.р�7��.	$��Right=�$��Bottom=�$��15��$��15��$
 Fill=����	#FF87CDEE$��3�� �� $
 True�� �� *
IsSelected+.a��� $ TopLeftPath�� � ��
 � ����� $ TopRightPath�� � ��
 � ����� $ BottomLeftPath�� � ��
 � ����� $ BottomRightPath�� � ��
 � ����� "  .R�� ���� *	ItemWidth+���� *
ItemHeight+   $
	 Left=�.+�� $��3q�#���  .+�  F� $
 TopLeftPath��$��2��"����k"��pѰ��pѰ��H	$
��Left=�$	��Top=�$��15��$��15��$
 Fill=����	#FF87CDEE$��3��F� $
 TopRightPath��$��2��"�������kч	��kч	�e�	$��Right=�$	��Top=�$��15��$��15��$
 Fill=����	#FF87CDEE$��3��F� $
 BottomLeftPath��$��2��'���P�Ed7�@�@��E�� ����� 	$
��Left=�$��Bottom=�$��15��$��15��$
 Fill=����	#FF87CDEE$��3��F� $
 BottomRightPath��$��2��"����h�흤 �h���.р�7��.	$��Right=�$��Bottom=�$��15��$��15��$
 Fill=����	#FF87CDEE$��3�� �� $
 True�� �� *
IsSelected+.a��� $ TopLeftPath�� � ��
 � ����� $ TopRightPath�� � ��
 � ����� $ BottomLeftPath�� � ��
 � ����� $ BottomRightPath�� � ��
 � ���