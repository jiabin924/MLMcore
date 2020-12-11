Public Class Window1
    Dim pid As String
    Dim jishuan As String
    Dim zhijie As Integer
    Private Sub tongji(ByVal targetItemContainer As ItemsControl)
        If targetItemContainer Is Nothing Then
            Return
        End If
        If targetItemContainer.Items Is Nothing Then
            Return
        End If
        Dim i As Integer
        For i = 0 To targetItemContainer.Items.Count - 1 Step i + 1
          
            Dim treeItem As TreeViewItem = targetItemContainer.Items(i)
      
            If treeItem Is Nothing Then
             
                Continue For
            End If
            If Not treeItem.HasItems Then
                'If Val(xianshi.Content) < 1000 Then



                '    For io As Integer = 0 To Int((10 * Rnd()) + 1)
                '        Dim treea2 As New TreeViewItem
                '        treea2.Header = "id" + io.ToString + Rnd().ToString

                '        '  treea2.IsExpanded = True
                '        treeItem.Items.Add(treea2)
                '    Next
                'End If
                Continue For
            End If
            If xianshi.Content = "ffdf" Then
                xianshi.Content = treeItem.Items.Count.ToString
             
            Else
                xianshi.Content = (Val(xianshi.Content) + treeItem.Items.Count).ToString
                

            End If
            tongjiyi(treeItem)
            If Int(zhijie / 1000) > 0 Then
                fenf.Content = (Val(fenf.Content) + 1).ToString
            End If

            zhijie = 0
            tongji(treeItem)

        Next
    End Sub

    Private Sub tongjiadd(ByVal targetItemContainer As ItemsControl)
        If targetItemContainer Is Nothing Then
            Return
        End If
        If targetItemContainer.Items Is Nothing Then
            Return
        End If
        Dim i As Integer
        For i = 0 To targetItemContainer.Items.Count - 1 Step i + 1

            Dim treeItem As TreeViewItem = targetItemContainer.Items(i)

            If treeItem Is Nothing Then

                Continue For
            End If
            If Not treeItem.HasItems Then
                If Val(xianshi.Content) < 1000 Then



                    For io As Integer = 0 To Int((10 * Rnd()) + 1)
                        Dim treea2 As New TreeViewItem
                        treea2.Header = "id" + io.ToString + Rnd().ToString

                        '  treea2.IsExpanded = True
                        treeItem.Items.Add(treea2)
                    Next
                End If
                Continue For
            End If
            If xianshi.Content = "ffdf" Then
                xianshi.Content = treeItem.Items.Count.ToString

            Else
                xianshi.Content = (Val(xianshi.Content) + treeItem.Items.Count).ToString


            End If


        

            tongji(treeItem)
            'zhijie = 0
        Next
    End Sub
    Private Sub Window_Loaded(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles MyBase.Loaded
  




    End Sub

    Private Sub jiabin_Loaded(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles jiabin.Loaded
        'Dim jiabins As TreeView = sender

        'Dim treeadd As TreeViewItem = CType(jiabins.ItemsSource, TreeViewItem)
        'Dim treea As New TreeViewItem
        'treeadd.Items.Add(treea)
    End Sub

    Private Sub jiabin_SelectedItemChanged(ByVal sender As System.Object, ByVal e As System.Windows.RoutedPropertyChangedEventArgs(Of System.Object)) Handles jiabin.SelectedItemChanged

        Dim jiabins As TreeView = sender
        Dim treeadd As TreeViewItem = CType(jiabins.SelectedItem, TreeViewItem)
        If treeadd.Items.Count = 0 Then
            For i As Integer = 0 To Int((10 * Rnd()) + 1)
                Dim treea As New TreeViewItem
                treea.Header = "id" + i.ToString + Rnd().ToString

                treea.IsExpanded = True
                treeadd.Items.Add(treea)
            Next


        End If
        'Dim tnRoot As TreeViewItem, tnCurrent As TreeViewItem, tnCurrentPar As TreeViewItem


        'tnRoot = treeadd
        'tnCurrentPar = tnRoot
        'tnCurrent = tnCurrentPar.Items(0)
        'While tnCurrent.Items.Count <> -1 And (tnCurrent.Items(0) <> tnRoot.Items(0))
        '    While Not tnCurrent.Items.Count <> -1
        '        If xianshi.Content = "ffdf" Then
        '            xianshi.Content = "1"
        '        Else
        '            xianshi.Content = (Val(xianshi.Content) + 1).ToString
        '        End If
        '        If tnCurrent.Items.Count > 0 Then
        '            tnCurrentPar = tnCurrent
        '            tnCurrent = tnCurrent.Items(0)
        '        ElseIf tnCurrent.ToString <> tnCurrentPar.Items(tnCurrentPar.Items.Count - 1).ToString Then
        '            tnCurrent = tnCurrent

        '        End If
        '    End While

        'End While
        'Dim hhu As ItemsControl
        'hhu = treeadd
        xianshi.Content = "ffdf"
        jiangjing.Content = "0"
        zhijie = 0
        fenf.Content = "0"
        tongji(treeadd)
        '减压计算
        'If Not (shuzi.Content) And Val(shuzi.Content) > pid Then
        '    pid = treeadd.PersistId
        'End If
       
        shuzi.Content = Val(xianshi.Content) * 50 * 0.5

        If Int(Val(xianshi.Content) / 1000) > 0 Then

            jiangjing.Content = Int(Val(xianshi.Content / 1000)) * 1000
        End If



    End Sub

    Private Sub jiabin_MouseRightButtonDown(ByVal sender As System.Object, ByVal e As System.Windows.Input.MouseButtonEventArgs) Handles jiabin.MouseRightButtonDown

        Dim jiabins As TreeView = sender
        Dim treeadd As TreeViewItem = CType(jiabins.SelectedItem, TreeViewItem)
        tongjiadd(treeadd)

    End Sub


    Private Sub tongjiyi(ByVal targetItemContainer As ItemsControl)
        If targetItemContainer Is Nothing Then
            Return
        End If
        If targetItemContainer.Items Is Nothing Then
            Return
        End If
        Dim i As Integer
        For i = 0 To targetItemContainer.Items.Count - 1 Step i + 1

            Dim treeItem As TreeViewItem = targetItemContainer.Items(i)

            If treeItem Is Nothing Then

                Continue For
            End If
            If Not treeItem.HasItems Then
              Continue For
            End If
            If zhijie = Nothing Then
                zhijie = treeItem.Items.Count

            Else
                zhijie = zhijie + treeItem.Items.Count

            End If


            tongjiyi(treeItem)
        Next
    End Sub
End Class
