   M S B A M L   `   `   `  ����D  @WPF(MVVM), Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:WPF_MVVM_	WPF_MVVM_  5   	   9!clr-namespace:WPF_MVVM_.ViewModelWPF_MVVM_.ViewModel  5   	       WPF_MVVM_.ProductsWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:WPF_MVVM_     5   	   4local1!clr-namespace:WPF_MVVM_.ViewModel     5   	     � Title$  ProductsWindow��5	   	   $	��450��6    $	��800��6-    � DataContext 5
      *   $WPF_MVVM_.ViewModel.ProductViewModel  5   
   .��5      �� .+�5   
   �� $	��300��64   ��6   �� *
Products+ �� View 5      �� 5      .P�5      �� $��ID��6%    �� DisplayMemberBinding 61   �� *Id+�� 5      $
��Name��6%    63   �� *Name+�� 5      $	��Age��6%    62   �� *	UnitBrief+�� 5      $	��Age��6%    62   �� *	UnitPrice+�� 5      $	��Age��6%    62   �� *Description+�� 5      $	��Age��6%    62   �� *Image+�� 5      $	��Age��6%    62   �� *
SupplierId+5      5      �� 5   
   ��6   �� *	YearDay+ �� FallbackValue$ trống�� �� Mode$ OneWay=��� 5   
   ��6   �� *Serial+$ Serial���� 5   
   $��ExecuteActionCommand��6   $��ExecuteActionCommand��6^   ��60   �� *OpenProductsWindowCommand+6^   �� 5   
   $��SendDataCommand��6   $��SendDataCommand��6Y   ��6+   �� *OpenProductsWindowCommand+6Y   �� 5   
   $��Print��6   $��Print��6O   ��6!   �� *OpenProductsWindowCommand+6O   �� 5    
   $��PrintInventory��6   $��PrintInventory��6X   ��6*   �� *OpenProductsWindowCommand+6X   �� 5!   
   $��PrintInventory��6   $��PrintInventory��6X   ��6*   �� *OpenProductsWindowCommand+6X   �� 5"   
   $��RePrint��6   $��RePrint��6Q   ��6#   �� *OpenProductsWindowCommand+6Q   �� 5#   
   $��PrintHoliday��6   $��PrintHoliday��6V   ��6(   �� *OpenProductsWindowCommand+6V   �� 5$   
   $��PrintSample��6   $��PrintSample��6U   ��6'   �� *OpenProductsWindowCommand+6U   5%      5&      