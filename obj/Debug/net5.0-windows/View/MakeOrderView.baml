   M S B A M L   `   `   `  ����D  @PizzaTime, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:PizzaTime.ViewPizzaTime.View  5      "    PizzaTime.View.MakeOrderView   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:PizzaTime.View     5      .��5
      �   � IsSharedSizeScope$
  True��6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   .+�5   
   �� $��
Make Order��6    
  Header#��[  6&   $��0��6F   � 5   
   $��1��6   $��0 25 0 0q�6    5      �� 5      $
��auto �6    �� 5      $
��auto �6    .+�5      �� $��Customer��6   $��15(�6(   $��0��66   �� 5      $��1��6   $��0 5 0 0q�6b   ��6#   �� *
customer+ �� UpdateSourceTrigger$ PropertyChanged=�6b   5      � 5!   
   $��2��6   $��0 10 0 0q�6    5"      �� 5#      $
��auto �6    �� 5$      $
��auto �6     � ColumnDefinitions 5&      �� 5'      $
��auto �6#    z� SharedSizeGroup$ FirstColumn��60   �� 5)      $
��auto �6#   $ SecondColumn��60   .+�5,      �� $��Ingredient 1��6   $��15(�6,   $��0��6:   �� 5-      $��1��6   $��0 5 0 0q�6e   ��6#   �� *Ingredients+$ PropertyChanged=�6e   �� 5/      $��Ingredient 2��6   $��5 0 0 0q�6,   $��15(�6=   $��1��6K   �� 50      $��1��6   $��10 5 0 0q�6e   $��1��6w   ��6#   �� *Ingredients+$ PropertyChanged=�6w   52      � 54   
   $��3��6   $��0 10 0 0q�6    55      �� 56      $
��auto �6    �� 57      $
��auto �6     59      �� 5:      $
��auto �6#   $ FirstColumn��60   �� 5;      $
��auto �6#   $ SecondColumn��60   .+�5>      �� $��
Start Date��6   $��15(�6*   $��0��68   (  "System.Windows.Controls.DatePicker  5?      $��1��6   $��0 5 0 0q�6n      SelectedDate 6&   �� *	StartDate+$ PropertyChanged=�6n   �� 5A      $��End Date��6   $��5 0 0 0q�6(   $��15(�69   $��1��6G     5B      $��1��6   $��10 5 0 0q�6l   $��1��6~    6&   �� *	EndDate+$ PropertyChanged=�6~   5D      �� 5E   
    �� Orientation$ 
Horizontal=�6   $��4��6.   $��0 25 0 0q�6;   .+�5F      �� $��Submit��6   ��6&   �� *SubmitCommand+�� 5G      $��10 0 0 0q�6   $��Cancel��6'   ��68   �� *CancelCommand+5H      5J      5K      